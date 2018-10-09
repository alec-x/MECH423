#include <msp430.h>

volatile unsigned char x;
volatile unsigned char y;
volatile unsigned char z;

/**
 * main.c
 */
int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // Stop WD Timer

	// Power accelerometer
    P2DIR |= BIT7; // configure P2 to be output
    P2OUT |= BIT7; // configure P2 output to be high

	// set DCO clock to 1MHz, assign to all clocks
    CSCTL0_H = 0xA5;                                            // Unlock Clocks
    CSCTL1 = DCOFSEL0 + DCOFSEL1;                               // Set DCO to 8 MHz
    CSCTL2 = SELM__DCOCLK + SELA__DCOCLK + SELS__DCOCLK;        // Set all clocks to src DCO
	
    TB1CCR0 = 5000 - 1;
    TB1CCTL1 = CCIE;
    TB1CTL = TBSSEL__SMCLK + MC__UP + ID__8;
    TB0EX0 = TBIDEX__8;
    TB1CTL |= TBCLR;

	//Configure A12-14 as Analog in
	P3SEL0 |= BIT0 + BIT1 + BIT2; // X Y Z
    P3SEL1 |= BIT0 + BIT1 + BIT2;
	
	//Configure UART
    P2SEL0 &= ~(BIT0 + BIT1);                                   //Config. UART Port
    P2SEL1 |= BIT0 + BIT1;
    UCA0CTLW0 = UCSSEL0;                                        // ACLK src, also UART is enabled
    UCA0MCTLW = 0x4900 + UCOS16 + UCBRF0;                       // Table 18-5 Data Sheet, p. 491
    UCA0BRW = 52;

	//Configure ADC
    ADC10CTL0 |= ADC10ON;                   // Turn on
    ADC10CTL1 |= ADC10SHP  + ADC10CONSEQ_0; // From sampling timer
    ADC10CTL2 |= ADC10RES;                  // Set incoming res. to 10 bits
    _EINT();

    while(1){

        // x
        ADC10CTL0 &= ~(ADC10ENC + ADC10SC); // Disable conversion to set new channel
        ADC10MCTL0 = ADC10INCH_12;         // Turn on x-channel (A12)
        ADC10CTL0 |= ADC10ENC + ADC10SC;    // Enable and start
        while(ADC10CTL1 & ADC10BUSY);

        x = ADC10MEM0 >> 2;                 // Bitshift right by 2
        _NOP();


        // y
        ADC10CTL0 &= ~(ADC10ENC + ADC10SC); // Disable conversion to set new channel
        ADC10MCTL0 = ADC10INCH_13;         // Turn on y-channel (A13)
        ADC10CTL0 |= ADC10ENC + ADC10SC;    // Enable and start
        while(ADC10CTL1 & ADC10BUSY);

        y = ADC10MEM0 >> 2;                 // Bitshift right by 2
        _NOP();


        // z
        ADC10CTL0 &= ~(ADC10ENC + ADC10SC); // Disable conversion to set new channel
        ADC10MCTL0 = ADC10INCH_14;         // Turn on z-channel (A14)
        ADC10CTL0 |= ADC10ENC + ADC10SC;    // Enable and start
        while(ADC10CTL1 & ADC10BUSY);

        z = ADC10MEM0 >> 2;                 // Bitshift right by 2
        _NOP();
    }

    return 0;
}

#pragma vector = TIMER1_B1_VECTOR
__interrupt void TIMER1_B1_ISR(void){
    while(!(UCA0IFG & UCTXIFG));
    UCA0TXBUF = 255;
    while(!(UCA0IFG & UCTXIFG));
    UCA0TXBUF = x;
    while(!(UCA0IFG & UCTXIFG));
    UCA0TXBUF = y;
    while(!(UCA0IFG & UCTXIFG));
    UCA0TXBUF = z;
    _NOP();
    TB1CCTL1 ^= CCIFG;
}
