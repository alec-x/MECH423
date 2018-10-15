#include <msp430.h> 

volatile unsigned char xAccel = 0;
volatile unsigned int curr = 0;
volatile unsigned int average = 0;
unsigned int i = 0;
char queue[16];

int main(void)
{
    int counter; // x = 0, y = 1, z = 2
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer

    // Power accelerometer
    P2DIR |= BIT7; // configure P2 to be output
    P2OUT |= BIT7; // configure P2 output to be high

    // set DCO clock to 1MHz, assign to all clocks
    CSCTL0_H = 0xA5;
    CSCTL1 |= DCOFSEL0 + DCOFSEL1;       // Set max. DCO setting =8MHz
    CSCTL2 = SELA_3 + SELS_3 + SELM_3;   // set ACLK = SMCLK = MCLK

    //Configure timer interrupt A
    TA0CTL = TASSEL_1 + MC_1 + ID_3;      // use ACLKC
    TA0CCTL0 = CCIE;               // count to TA0CCR0, enable interrupt
    TA0CCR0 = 10000;               // PWM Period clock = 8MHz, desired freq 100Hz, factor 10000 * 8 (in TA0CTL)

    //Configure timer interrupt B
    P3DIR |= BIT4;                       // P3.4 output
    P3SEL0 |= BIT4;                      // P3.4 options select
    TB1CCR0 = 16000;                      // PWM Period clock = 8MHz, desired freq 500Hz, factor 2000
    TB1CCTL1 = OUTMOD_7;                 // CCR1 reset/set
    TB1CCR1 = 100;                      // CCR1 PWM duty cycle
    TB1CTL = TBSSEL_1 + MC_1;            //set up  timer B in up count mode with ACLK as source
    TB1CCTL0 = CCIE;

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
    ADC10CTL0 = ADC10SHT_2 + ADC10ON;                         // 16ADCclks, ADC ON
    ADC10CTL1 = ADC10CONSEQ_0 + ADC10SHP + ADC10SSEL_1;       // multiple channel single sequence
    ADC10CTL2 |= ADC10RES;                                    // 10-bit resolution, shift when read
    ADC10MCTL0 |= ADC10INCH_12; //start with channel 12, x
    _EINT(); //global interrupt enable


    while(1);
}

#pragma vector = TIMER0_A0_VECTOR
__interrupt void TIMERA_ISR(void)
{
    while(!(UCA0IFG & UCTXIFG)); //if currently transmitting, then loop on itself
    UCA0TXBUF = xAccel - 90;
    ADC10CTL0 |= ADC10ENC + ADC10SC;        // Start sampling
    while (ADC10CTL1 & BUSY);               // Wait if ADC10 core is active

    xAccel = ADC10MEM0 >> 2;
    ADC10CTL0 &= ~(ADC10ENC + ADC10SC);

    queue[curr] = xAccel;
    if(curr == 15){
        curr = 0;
    }
    else{
        curr += 1;
    }
    average = 0;
    for(i = 0; i < 16; i++){
        average += queue[i];
    }
}

#pragma vector = TIMER1_B0_VECTOR
__interrupt void TIMERB_ISR(void)
{
    TB1CCR1 = (average-110)*100;
}
