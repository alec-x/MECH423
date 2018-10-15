#include <msp430.h> 

volatile unsigned char tempVolt = 0;
const int base = 56;

int main(void)
{
	WDTCTL = WDTPW | WDTHOLD;	// stop watchdog timer

	// Power accelerometer
	P2DIR |= BIT7; // configure P2 to be output
	P2OUT |= BIT7; // configure P2 output to be high
	
	// set DCO clock to 1MHz, assign to all clocks
	CSCTL0_H = 0xA5;
    CSCTL1 |= DCOFSEL0 + DCOFSEL1;       // Set max. DCO setting =8MHz
    CSCTL2 = SELA_3 + SELS_3 + SELM_3;   // set ACLK = SMCLK = MCLK

	//Configure timer interrupt
    TA0CTL = TASSEL_1 + MC_1 + ID_3;      // use ACLKC
    TA0CCTL0 = CCIE;               // count to TA0CCR0, enable interrupt
    TA0CCR0 = 40000;               // PWM Period clock = 8MHz, desired freq 25Hz, factor 40000 * 8 (in TA0CTL)

    //Configure LEDs
    P3DIR |= BIT4 + BIT5 + BIT6 + BIT7; //Set P3 direction to output for P3.4,3.5,4.6, 1b
    PJDIR |= BIT0 + BIT1 + BIT2 + BIT3; //Set PJ direction to output for PJ.0,J.1,J.2, 1b

    //Configure UART
    P2SEL0 &= ~(BIT0 + BIT1); //Configure ports to be UART
    P2SEL1 |= BIT0 + BIT1;
    UCA0CTLW0 = UCSSEL0; // clock for UART comes from ACLK, also UART is enabled
    UCA0MCTLW = 0x4900 + UCOS16 + UCBRF0;
    UCA0BRW = 52;
	
	//Configure ADC
    ADC10CTL0 = ADC10SHT_6 + ADC10ON;                         // 16ADCclks, ADC ON
    ADC10CTL1 = ADC10CONSEQ_0 + ADC10SHP + ADC10SSEL_1;
    ADC10CTL2 |= ADC10RES;                                    // 10-bit resolution, shift when read
    ADC10MCTL0 |= ADC10SREF_1 + ADC10INCH_10; //start with channel 10, x

    while(REFCTL0 & REFGENBUSY);              // If ref generator busy, WAIT
    REFCTL0 |= REFVSEL_0+REFON;               // Select internal ref = 1.5V
  											// Internal Reference ON   
    //ADC10IE |=ADC10IE0;                       // enable the Interrupt request for a completed ADC10_B conversion
    
    __delay_cycles(400);                      // Delay for Ref to settle
	
    _EINT(); //global interrupt enable
    while(1)
    {
        __delay_cycles(400);
        ADC10CTL0 |= ADC10ENC + ADC10SC;        // Start sampling
        while (ADC10CTL1 & BUSY);               // Wait if ADC10 core is active
	    tempVolt = ADC10MEM0;
		ADC10CTL0 &= ~(ADC10ENC + ADC10SC);
    }
}

#pragma vector = TIMER0_A0_VECTOR
__interrupt void TIMER0_ISR(void)
{
    while(!(UCA0IFG & UCTXIFG)); //if currently transmitting, then loop on itself
    UCA0TXBUF = tempVolt;
    switch(tempVolt){
    case (base - 1):
        PJOUT = 0;
        P3OUT = 0;
        break;
    case base:
        PJOUT = 0;
        P3OUT = 0;
        break;
    case (base + 1):
        PJOUT = BIT0;
        P3OUT = 0;
        break;
    case (base + 2):
        PJOUT = BIT0 + BIT1;
        P3OUT = 0;
        break;
    case (base + 3):
        PJOUT = BIT0 + BIT1 + BIT2;
        P3OUT = 0;
        break;
    case (base + 4):
        PJOUT = BIT0 + BIT1 + BIT2 + BIT3;
        P3OUT = 0;
        break;
    case (base + 5):
        PJOUT = BIT0 + BIT1 + BIT2 + BIT3;
        P3OUT = BIT4;
        break;
    case (base + 6):
        PJOUT = BIT0 + BIT1 + BIT2 + BIT3;
        P3OUT = BIT4 + BIT5;
        break;
    case (base + 7):
        PJOUT = BIT0 + BIT1 + BIT2 + BIT3;
        P3OUT = BIT4 + BIT5 + BIT6;
        break;
    case (base + 8):
        PJOUT = BIT0 + BIT1 + BIT2 + BIT3;
        P3OUT = BIT4 + BIT5 + BIT6 + BIT7;
        break;
    case (base + 9):
        PJOUT = BIT0 + BIT1 + BIT2 + BIT3;
        P3OUT = BIT4 + BIT5 + BIT6 + BIT7;
        break;
    }
}

