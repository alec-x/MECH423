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
unsigned int order = 0;
char dataByte1, dataByte2, directionByte, escapeByte, modeByte;
//1 left, 3 up, 5 right, 7 down, 8 down left
// for wire configuration:
// starting from edge, black(1) brown(3) orange(2) yellow(4)
static const unsigned int directionTableA[8] =
{
    BIT4,
    BIT4,
    0,
    BIT5,
    BIT5,
    BIT5,
    0,
    BIT4

};

static const unsigned int directionTableB[8] =
{
    0,
    BIT4,
    BIT4,
    BIT4,
    0,
    BIT5,
    BIT5,
    BIT5
};

int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer
    CSCTL0_H = 0xA5;
    CSCTL1 = DCOFSEL0 + DCOFSEL1;
    CSCTL2 = SELM0 + SELM1 + SELA0 + SELA1 + SELS0 + SELS1;

    //Configure LED
    PJDIR |= BIT0 + BIT1 + BIT2;

    //Configure ports to be UART
    P2SEL0 &= ~(BIT5 + BIT6);
    P2SEL1 |= BIT5 + BIT6;

    //Configure UART 1
    UCA1CTLW0 = UCSSEL0; // clock for UART comes from ACLK, also UART is enabled
    UCA1MCTLW = 0x4900 + UCOS16 + UCBRF0; //4900 F700
    UCA1BRW = 52;
    UCA1IE |= UCRXIE;

    //Configure timer interrupt
    TA0CTL = TASSEL_1 + MC_1 + ID_3;      // use ACLKC
    TA0EX0 = TAIDEX_7;
    TA0CCTL0 |= CCIE;               // count to TA0CCR0, enable interrupt
    TA0CCR0 = 50000;               // PWM Period clock = 250kHz, desired freq 5Hz, factor 25000 * 8 (in TA0CTL)

    _EINT(); //global interrupt enable

    //Configure Output (A1 and A2)
    P1DIR |= BIT4 + BIT5;                       // P1.4, 1.5 output
    //Configure Output (B1 and B2)
    P3DIR |= BIT4 + BIT5;                       // P1.4, 1.5 output

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
        while(currSize < 6);
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

        directionByte = queue[last];
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

        modeByte = queue[last];
        queue[last] = NULL;
        currSize -= 1;
        if(last == 49){
            last = 0;
        }
        else{
            last += 1;
        }

        if(escapeByte == 1){
            dataByte1 = 255;
        } else if(escapeByte == 2){
            dataByte2 = 255;
        } else if(escapeByte ==3){
            dataByte1 = 255;
            dataByte2 = 255;
        }

        if(modeByte == 0){
            TA0CCTL0 &= ~CCIE;
            P1OUT = directionTableA[order];
            P3OUT = directionTableB[order];
            if(directionByte == 1){
                if(order == 7){
                    order = 0;
                } else{
                    order++;
                }
            } else{
                if(order == 0){
                    order = 7;
                } else{
                    order--;
                }
            }

        } else if(modeByte == 1){
            TA0CCTL0 |= CCIE;
            TA0CCR0 = (dataByte1 << 8) + dataByte2;
        }
    }

    return 0;
}

#pragma vector = USCI_A1_VECTOR
__interrupt void USCI_A1_ISR(void)
{
    unsigned char RxByte = 0;
    RxByte = UCA1RXBUF;

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

#pragma vector = TIMER0_A0_VECTOR
__interrupt void TIMER0_ISR(void)
{
    if(directionByte == 1){
        if(order == 7){
            order = 0;
        } else{
            order++;
        }
    } else{
        if(order == 0){
            order = 7;
        } else{
            order--;
        }
    }
    P1OUT = directionTableA[order];
    P3OUT = directionTableB[order];
}
