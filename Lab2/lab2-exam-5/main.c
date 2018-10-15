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
unsigned int orbCtl;
unsigned int mode = 4;
unsigned int temp = 0;
char commandByte;
char dataByte = 0;

int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer
    CSCTL0_H = 0xA5;
    CSCTL1 = DCOFSEL0 + DCOFSEL1;
    CSCTL2 = SELM0 + SELM1 + SELA0 + SELA1 + SELS0 + SELS1;

    //Configure LED
    P3DIR |= BIT4 + BIT5 + BIT6 + BIT7; //Set P3 direction to output for P3.4,3.5,4.6, 1b
    PJDIR |= BIT0 + BIT1 + BIT2 + BIT3; //Set PJ direction to output for PJ.0,J.1,J.2, 1b

    //Configure ports to be UART
    P2SEL0 &= ~(BIT0 + BIT1);
    P2SEL1 |= BIT0 + BIT1;

    //Configure UART 0
    UCA0CTLW0 = UCSSEL0; // clock for UART comes from ACLK, also UART is enabled
    UCA0MCTLW = 0xF700 + UCOS16 + UCBRF0;
    UCA0BRW = 52;
    UCA0IE |= UCRXIE;

    _EINT(); //global interrupt enable

    //Configure duty cycle
    P3DIR |= BIT4;                       // P3.4 output
    P3SEL0 |= BIT4;                      // P3.4 options select
    TB1CCR0 = 16000;                      // PWM Period clock = 8MHz, desired freq 500Hz, factor 16000
    TB1CCTL1 = OUTMOD_7;                 // CCR1 reset/set
    TB1CCR1 = 0;                      // CCR1 PWM duty cycle
    TB1CTL = TBSSEL_1 + MC_1;            //set up  timer B in up count mode with ACLK as source

    while(1){
        if(currSize > 2){
            queue[last] = NULL;
            currSize -= 1;
            if(last == 49){
                last = 0;
            }
            else{
                last += 1;
            }

            commandByte = queue[last];
            queue[last] = NULL;
            currSize -= 1;
            if(last == 49){
                last = 0;
            }
            else{
                last += 1;
            }

            dataByte = queue[last];
            queue[last] = NULL;
            currSize -= 1;
            if(last == 49){
                last = 0;
            }
            else{
                last += 1;
            }
        }

        mode = commandByte;

        switch(mode){
        case 1:
            if(orbCtl > TB1CCR0 - 10){
                orbCtl = 0;
            }else{
                orbCtl++;
            }
            TB1CCR1 = orbCtl;
            for(temp = dataByte +1; temp > 0; temp--){
                __delay_cycles(1);
            }

            break;
        case 2:
            if(orbCtl < 10){
                orbCtl = TB1CCR0 - 1;
            }else{
                orbCtl--;
            }
            TB1CCR1 = orbCtl;
            for(temp = dataByte +1; temp > 0; temp--){
                __delay_cycles(1);
            }
            break;
        case 4:
            TB1CCR1 = 0;
            __delay_cycles(1000);
            break;
        }
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
