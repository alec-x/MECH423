#include <msp430.h>
#include <stdio.h>

/**
 * main.c
 */
int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer
    CSCTL0_H = 0xA5;
    CSCTL1 = DCOFSEL0 + DCOFSEL1;
    CSCTL2 = SELM0 + SELM1 + SELA0 + SELA1 + SELS0 + SELS1;

    //Configure LED
    PJDIR |= BIT0 + BIT1 + BIT2;

    //Configure ports to be UART
    //P2SEL0 &= ~(BIT0 + BIT1);
    //P2SEL1 |= BIT0 + BIT1;

    //Configure ports to be UART
    P2SEL0 &= ~(BIT5 + BIT6);
    P2SEL1 |= BIT5 + BIT6;

    //Configure UART 0
    UCA1CTLW0 = UCSSEL0; // clock for UART comes from ACLK, also UART is enabled
    UCA1MCTLW = 0xF700 + UCOS16 + UCBRF0;
    UCA1BRW = 52;
    UCA1IE |= UCRXIE;

    _EINT(); //global interrupt enable

    while(1);
    return 0;
}

#pragma vector = USCI_A1_VECTOR
__interrupt void USCI_A1_ISR(void)
{
    __no_operation();
}
