#include <msp430.h> 

volatile unsigned char xAccel = 0;
volatile unsigned char yAccel = 0;
volatile unsigned char zAccel = 0;

int main(void)
{
    int counter; // x = 0, y = 1, z = 2
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

    //Configure A12-14 as Analog in
    P3SEL0 |= BIT0 + BIT1 + BIT2;
    P3SEL1 |= BIT0 + BIT1 + BIT2;

    //Configure UART
    P2SEL0 &= ~(BIT0 + BIT1); //Configure ports to be UART
    P2SEL1 |= BIT0 + BIT1;
    UCA0CTLW0 = UCSSEL0; // clock for UART comes from ACLK, also UART is enabled
    UCA0MCTLW = 0x4900 + UCOS16 + UCBRF0;
    UCA0BRW = 52;
	
	//Configure ADC
    ADC10CTL0 = ADC10SHT_2 + ADC10ON;                         // 4ADCclks, ADC ON
    ADC10CTL1 = ADC10CONSEQ_0 + ADC10SHP + ADC10SSEL_1;       // multiple channel single sequence
    ADC10CTL2 |= ADC10RES;                                    // 10-bit resolution, shift when read
    ADC10MCTL0 |= ADC10INCH_12; //start with channel 12, x
    counter = 0; // x = 0, y = 1, z = 2
    _EINT(); //global interrupt enable


    while(1)
    {
        while (ADC10CTL1 & BUSY);               // Wait if ADC10 core is active
        ADC10CTL0 |= ADC10ENC + ADC10SC;        // Start sampling

        if(counter == 0){
             xAccel = ADC10MEM0 >> 2;
             ADC10CTL0 &= ~(ADC10ENC + ADC10SC);
             ADC10MCTL0 = ADC10INCH_13;
             counter++;
         }
         else if(counter == 1){
             yAccel = ADC10MEM0 >> 2;
             ADC10CTL0 &= ~(ADC10ENC + ADC10SC);
             ADC10MCTL0 = ADC10INCH_14;
             counter++;
         }
         else if(counter == 2){
             zAccel = ADC10MEM0 >> 2;
             ADC10CTL0 &= ~(ADC10ENC + ADC10SC);
             ADC10MCTL0 = ADC10INCH_12;
             counter = 0;
         }
    }
}

#pragma vector = TIMER0_A0_VECTOR
__interrupt void TIMER0_ISR(void)
{
    while(!(UCA0IFG & UCTXIFG)); //if currently transmitting, then loop on itself
    UCA0TXBUF = 255;

    while(!(UCA0IFG & UCTXIFG)); //if currently transmitting, then loop on itself
    UCA0TXBUF = xAccel;

    while(!(UCA0IFG & UCTXIFG)); //if currently transmitting, then loop on itself
    UCA0TXBUF = yAccel;

    while(!(UCA0IFG & UCTXIFG)); //if currently transmitting, then loop on itself
    UCA0TXBUF = zAccel;

}
