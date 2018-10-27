#include <msp430.h>

int main(void)
{
    WDTCTL = WDTPW | WDTHOLD; // stop watchdog timer

    // Configure Clock
    CSCTL0_H = 0xA5;
    CSCTL1 |= DCOFSEL0 + DCOFSEL1;       // Set max. DCO setting =8MHz
    CSCTL2 = SELA_3 + SELS_3 + SELM_3;   // set ACLK = SMCLK = MCLK = DCO/8
    CSCTL3 = DIVA_3 + DIVS_3 + DIVM_3;   // set all dividers

    //Configure ports to be UART
    P2SEL0 &= ~(BIT0 + BIT1);
    P2SEL1 |= BIT0 + BIT1;

    //Configure UART 0
    UCA0CTLW0 = UCSSEL0; // clock for UART comes from ACLK, also UART is enabled
    UCA0MCTLW = 0xF700 + UCOS16 + UCBRF0;
    UCA0BRW = 52;
    UCA0IE |= UCRXIE;

    _EINT(); //global interrupt enable

    //Configure Duty cycle
    P3DIR |= BIT4;                       // P3.4 output
    P3SEL0 |= BIT4;                      // P3.4 options select
    TB1CCTL1 = OUTMOD_7;                 // CCR1 reset/set
    TB1CCR1 = 100;                      // CCR1 PWM duty cycle, PWM Period clock = 1MHz
    TB1CTL = TBSSEL_1 + MC_2;            //set up  timer B in up count mode with ACLK as source

	while(1){
		__no_operation();
	}
    return 0;
}

#pragma vector = USCI_A0_VECTOR
__interrupt void USCI_A0_ISR(void)
{
    unsigned char RxByte = 0;
    RxByte = UCA0RXBUF;

    if(currSize < queueSize){
        queue[curr] = RxByte;
        if(curr == 49){
            curr = 0;
        }else{
            curr++;
        }
        currSize += 1;
    }

    __no_operation();
}
