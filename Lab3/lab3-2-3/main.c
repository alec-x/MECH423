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
char dataByte1, dataByte2, directionByte, escapeByte;

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

    _EINT(); //global interrupt enable

    //Configure Duty cycle (A1 and A2)
    P1DIR |= BIT4 + BIT5;                       // P1.4, 1.5 output
    P1SEL0 |= BIT4 + BIT5;                      // P1.4, 1.5 options select
    TB0CCTL1 = OUTMOD_7;                 // CCR1 reset/set
    TB0CCTL2 = OUTMOD_7;                 // CCR2 reset/set
    TB0CCR1 = 15000;                      // CCR1 PWM duty cycle, PWM Period clock = 8MHz
    TB0CCR2 = 100;                      // CCR1 PWM duty cycle, PWM Period clock = 8MHz
    TB0CTL = TBSSEL_1 + MC_2;            //set up  timer B in up count mode with ACLK as source

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

        if(escapeByte == 1){
            dataByte1 = 255;
        } else if(escapeByte == 2){
            dataByte2 = 255;
        } else if(escapeByte ==3){
            dataByte1 = 255;
            dataByte2 = 255;
        }

        freqInt = (dataByte1 << 8) + dataByte2;
        TB0CCR2 = freqInt;
        TB0CCR1 = freqInt;
		
		if(directionByte){
			TB0CCR1 = 0;
		}
		else{
		    TB0CCR2 = 0;
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
