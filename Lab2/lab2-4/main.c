#include <msp430.h> 


/**
 * main.c
 */
int main(void)
{
    int i;
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer
    CSCTL0_H = 0xA5;
    CSCTL1 = DCOFSEL0 + DCOFSEL1;
    CSCTL2 = SELM0 + SELM1 + SELA0 + SELA1 + SELS0 + SELS1;

    //Configure ports to be UART
    P2SEL0 &= ~(BIT0 + BIT1);
    P2SEL1 |= BIT0 + BIT1;

    //Configure LED 1
    PJDIR |= BIT0;

    //Configure UART 0
    UCA0CTLW0 = UCSSEL0; // clock for UART comes from ACLK, also UART is enabled
    UCA0MCTLW = 0xF700 + UCOS16 + UCBRF0;
    UCA0BRW = 52;
    UCA0IE |= UCRXIE;

    _EINT(); //global interrupt enable

    while(1){
/*
        while(!(UCA0IFG & UCTXIFG)); //if currently transmitting, then loop on itself

        UCA0TXBUF = 'A';

        for(i = 0; i < 10000; i++){
            _NOP();
        }
*/
    }

    return 0;
}

#pragma vector = USCI_A0_VECTOR
__interrupt void USCI_A0_ISR(void)
{
    unsigned char RxByte = 0;
    RxByte = UCA0RXBUF;
    while(!(UCA0IFG & UCTXIFG)); //if currently transmitting, then loop on itself


    UCA0TXBUF = RxByte; //echo back the received byte
    UCA0TXBUF = RxByte + 1;

    if (RxByte == 'j'){
        PJOUT |= BIT0;
    } else if(RxByte == 'k'){
        PJOUT &= ~BIT0;
    }
}
