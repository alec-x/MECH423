#include <msp430.h> 

volatile unsigned char tempVolt = 0;
const int base = 60;
const int increment = 100;
volatile unsigned int temp = 33;
int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer

    // Power accelerometer
    P2DIR |= BIT7; // configure P2 to be output
    P2OUT |= BIT7; // configure P2 output to be high

    // set DCO clock to 1MHz, assign to all clocks
    CSCTL0_H = 0xA5;
    CSCTL1 |= DCOFSEL0 + DCOFSEL1;       // Set max. DCO setting =8MHz
    CSCTL2 = SELA_3 + SELS_3 + SELM_3;   // set ACLK = SMCLK = MCLK

    //Set timer b stuff
    P3DIR |= BIT4;                       // P3.4 output
    P3SEL0 |= BIT4;                      // P3.4 options select
    TB1CCR0 = 16000;                      // PWM Period clock = 8MHz, desired freq 500Hz, factor 2000
    TB1CCTL1 = OUTMOD_7;                 // CCR1 reset/set
    TB1CCR1 = 100;                      // CCR1 PWM duty cycle
    TB1CTL = TBSSEL_1 + MC_1;            //set up  timer B in up count mode with ACLK as source
    TB1CCTL0 = CCIE;

    //Configure LEDs
    P3DIR |= BIT4; //Set P3 direction to output for P3.4
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
    ADC10MCTL0 |= ADC10SREF_1 + ADC10INCH_4; //start with channel 10, x

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

#pragma vector = TIMER1_B0_VECTOR
__interrupt void TIMER0_ISR(void)
{
    switch(tempVolt){
    case 180:
        TB1CCR1 = increment;
        break;
    case 175:
        TB1CCR1 = 2*increment;
        break;
    case 170:
        TB1CCR1 = 4*increment;
        break;
    case 165:
        TB1CCR1 = 6*increment;
        break;
    case 160:
        TB1CCR1 = 8*increment;
        break;
    case 155:
        TB1CCR1 = 10*increment;
        break;
    case 150:
        TB1CCR1 = 14*increment;
        break;
    case 145:
        TB1CCR1 = 18*increment;
        break;
    case 140:
        TB1CCR1 = 22*increment;
        break;
    case 135:
        TB1CCR1 = 30*increment;
        break;
    case 130:
        TB1CCR1 = 40*increment;
        break;
    }
    temp = TB1CCR1;
}

