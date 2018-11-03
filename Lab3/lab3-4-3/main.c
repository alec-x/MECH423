#include <msp430.h> 
volatile unsigned int upCount = 0;
volatile unsigned int downCount = 0;
volatile unsigned char escapeByte = 0;
volatile unsigned char up1 = 0;
volatile unsigned char up0 = 0;
volatile unsigned char down1 = 0;
volatile unsigned char down0 = 0;
int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer

    // set DCO clock to 8MHz, assign to all clocks
    CSCTL0_H = 0xA5;
    CSCTL1 |= DCOFSEL0 + DCOFSEL1;       // Set max. DCO setting =8MHz
    CSCTL2 = SELA_3 + SELS_3 + SELM_3;   // set ACLK = SMCLK = MCLK

    //Configure UART
    P2SEL0 &= ~(BIT5 + BIT6); //Configure ports to be UART
    P2SEL1 |= BIT5 + BIT6;

    //Configure UART
    UCA1CTLW0 = UCSSEL0; // clock for UART comes from ACLK, also UART is enabled
    UCA1MCTLW = 0x4900 + UCOS16 + UCBRF0;
    UCA1BRW = 52;
    UCA1IE |= UCRXIE;

    // Set P1.1 and 1.2 as input
    P1DIR &= ~(BIT1 + BIT2);
    P1SEL1 |= BIT1 + BIT2;

    //Configure timer A interrupt
    TA1CTL |= MC1; //cts mode
    TA0CTL |= MC1;


    //Configure timer interrupt
    TB0CTL = TBSSEL_1 + MC_1 + ID_3;      // use ACLKC
    TB0CCTL0 = CCIE;               // count to TA0CCR0, enable interrupt
    TB0CCR0 = 40000;               // PWM Period clock = 8MHz, desired freq 25Hz, factor 40000 * 8 (in TA0CTL)



    _EINT(); //global interrupt enable


    while(1);
}

#pragma vector = TIMER0_B0_VECTOR
__interrupt void TIMER0_ISR(void)
{
    // 255, UP1, UP0, DOWN1, DOWN0, ESCAPE
    // where 1 is most sig, 0 is least
    upCount = TA0R;
    downCount = TA1R;
    up1 = upCount >> 8;
    up0 = upCount;
    down1 = downCount >> 8;
    down0 = downCount;
    escapeByte = 0;
    if(up1==255){
        escapeByte += 1;
        up1 = 0;
    }
    if(up0==255){
        escapeByte += 2;
        up0 = 0;
    }
    if(down1==255){
        escapeByte += 4;
        down1 = 0;
    }
    if(down0==255){
        escapeByte += 8;
        down0 = 0;
    }
    while(!(UCA1IFG & UCTXIFG)); //if currently transmitting, then loop on itself
    UCA1TXBUF = 255;
    while(!(UCA1IFG & UCTXIFG)); //if currently transmitting, then loop on itself
    UCA1TXBUF = up1;
    while(!(UCA1IFG & UCTXIFG)); //if currently transmitting, then loop on itself
    UCA1TXBUF = up0;
    while(!(UCA1IFG & UCTXIFG)); //if currently transmitting, then loop on itself
    UCA1TXBUF = down1;
    while(!(UCA1IFG & UCTXIFG)); //if currently transmitting, then loop on itself
    UCA1TXBUF = down0;
    while(!(UCA1IFG & UCTXIFG)); //if currently transmitting, then loop on itself
    UCA1TXBUF = escapeByte;

    TA0CTL = TACLR;
    TA1CTL = TACLR;
}
