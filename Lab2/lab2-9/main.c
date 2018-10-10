#include <msp430.h>
#include <stdio.h>

/**
 * main.c
 */
const int queueSize = 50;
volatile unsigned int currSize = 0;
volatile unsigned int last = 0;
volatile unsigned int curr = 0;
char queue[50];
char errfull[] = "BUFFER FULL\n\r";
char errempty[] = "BUFFER EMPTY\n\r";

int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer
    CSCTL0_H = 0xA5;
    CSCTL1 = DCOFSEL0 + DCOFSEL1;
    CSCTL2 = SELM0 + SELM1 + SELA0 + SELA1 + SELS0 + SELS1;

    //Configure ports to be UART
    P2SEL0 &= ~(BIT0 + BIT1);
    P2SEL1 |= BIT0 + BIT1;

    //Configure UART 0
    UCA0CTLW0 = UCSSEL0; // clock for UART comes from ACLK, also UART is enabled
    UCA0MCTLW = 0xF700 + UCOS16 + UCBRF0;
    UCA0BRW = 52;
    UCA0IE |= UCRXIE;

    _EINT(); //global interrupt enable

    while(1){
        __no_operation();
    }

    return 0;
}

#pragma vector = USCI_A0_VECTOR
__interrupt void USCI_A0_ISR(void)
{
    unsigned char RxByte = 0;
    int i = 0;
    RxByte = UCA0RXBUF;

    if(RxByte == 13 && currSize > 0){
        while(!(UCA0IFG & UCTXIFG)); //if currently transmitting, then loop on itself
        UCA0TXBUF = queue[last]; //echo back the received byte
        queue[last] = NULL;
        currSize -= 1;

        if(last == 49){
            last = 0;
        }
        else{
            last += 1;
        }
    }
    else if(RxByte != 13 && currSize < queueSize){
        queue[curr] = RxByte;
        if(curr == 49){
            curr = 0;
        }else{
            curr++;
        }
        currSize += 1;
    } else if(currSize > queueSize - 1){
        for(i = 0; i < sizeof(errfull); i++){
            while(!(UCA0IFG & UCTXIFG)); //if currently transmitting, then loop on itself
            UCA0TXBUF = errfull[i]; //echo back the received byte
        }

    } else if(currSize == 0){
        for(i = 0; i < sizeof(errempty); i++){
            while(!(UCA0IFG & UCTXIFG)); //if currently transmitting, then loop on itself
            UCA0TXBUF = errempty[i]; //echo back the received byte
        }
    }


    __no_operation();

}
