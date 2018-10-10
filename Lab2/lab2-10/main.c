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
unsigned int freqInt;
char commandByte, dataByte1, dataByte2, escapeByte;

int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer
    CSCTL0_H = 0xA5;
    CSCTL1 = DCOFSEL0 + DCOFSEL1;
    CSCTL2 = SELM0 + SELM1 + SELA0 + SELA1 + SELS0 + SELS1;

    //Configure LED
    PJDIR |= BIT0 + BIT1 + BIT2;

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
    TB1CCR1 = 8000;                      // CCR1 PWM duty cycle
    TB1CTL = TBSSEL_1 + MC_1;            //set up  timer B in up count mode with ACLK as source

    while(1){
        while(queue[last] != 255 && currSize > 0){
            queue[last] = NULL;
            currSize -= 1;

            if(last == 49){
                last = 0;
            }
            else{
                last += 1;
            }
        }
        while(currSize < 5);
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

        dataByte1 = queue[last];
        queue[last] = NULL;
        currSize -= 1;
        if(last == 49){
            last = 0;
        }
        else{
            last += 1;
        }

        dataByte2 = queue[last];
        queue[last] = NULL;
        currSize -= 1;
        if(last == 49){
            last = 0;
        }
        else{
            last += 1;
        }

        escapeByte = queue[last];
        queue[last] = NULL;
        currSize -= 1;
        if(last == 49){
            last = 0;
        }
        else{
            last += 1;
        }

        if(commandByte == 0){
            if(escapeByte == 1){
                dataByte1 = 255;
            } else if(escapeByte == 2){
                dataByte2 = 255;
            } else if(escapeByte ==3){
                dataByte1 = 255;
                dataByte2 = 255;
            }

            freqInt |= dataByte1 << 8;
            freqInt += dataByte2;
            TB1CCR1 = freqInt;
        } else if(commandByte == 1){
            PJOUT ^= BIT0;
        } else if(commandByte == 2){
            PJOUT ^= BIT1;
        } else if(commandByte == 3){
            PJOUT ^= BIT2;
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
