#include <msp430.h>

volatile unsigned int sendFlag = 0;
volatile unsigned int upCount = 0;
volatile unsigned int downCount = 0;
volatile unsigned char escapeByte = 0;
volatile unsigned char up1 = 0;
volatile unsigned char up0 = 0;
volatile unsigned char down1 = 0;
volatile unsigned char down0 = 0;
volatile long absPos = 30000;
volatile long targetPos = 30100;

const int queueSize = 50;
volatile unsigned int currSize = 0;
volatile unsigned int last = 0;
volatile unsigned int curr = 0;
char queue[50];
unsigned int freqInt;
char dataByte1, dataByte2, directionByte, escapeByte2;

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
    //P1SEL0 = 0
    P1DIR &= ~(BIT1 + BIT2);
    P1SEL1 |= BIT1 + BIT2;

    //Configure timer A interrupt
    TA1CTL |= MC1; //cts mode
    TA0CTL |= MC1;


    //Configure timer interrupt
    TB1CTL = TBSSEL_1 + MC_1 + ID_3;      // use ACLKC
    TB1CCTL0 = CCIE;               // count to TA0CCR0, enable interrupt
    TB1CCR0 = 40000;               // PWM Period clock = 8MHz, desired freq 25Hz, factor 40000 * 8 (in TA0CTL)

    //Configure Duty cycle (A1 and A2)
    P1DIR |= BIT4 + BIT5;                       // P1.4, 1.5 output
    P1SEL0 |= BIT4 + BIT5;                      // P1.4, 1.5 options select
    TB0CCTL1 = OUTMOD_7;                 // CCR1 reset/set
    TB0CCTL2 = OUTMOD_7;                 // CCR2 reset/set
    TB0CCR1 = 0;                      // CCR1 PWM duty cycle, PWM Period clock = 8MHz
    TB0CCR2 = 0;                      // CCR1 PWM duty cycle, PWM Period clock = 8MHz
    TB0CTL = TBSSEL_1 + MC_2;            //set up  timer B in up count mode with ACLK as source


    _EINT(); //global interrupt enable


    while(1){
        /*
        if(queue[last] != 255 && currSize > 0){
            queue[last] = 0;
            currSize -= 1;

            if(last == 49){
               last = 0;
            }
            else{
               last += 1;
            }
        }
        if(currSize >= 5){
            queue[last] = 0;
            currSize -= 1;
            if(last == 49){
               last = 0;
            }
            else{
               last += 1;
            }

            dataByte1 = queue[last];
            queue[last] = 0;
            currSize -= 1;
            if(last == 49){
               last = 0;
            }
            else{
               last += 1;
            }

            dataByte2 = queue[last];
            queue[last] = 0;
            currSize -= 1;
            if(last == 49){
               last = 0;
            }
            else{
               last += 1;
            }

            directionByte = queue[last];
            queue[last] = 0;
            currSize -= 1;
            if(last == 49){
               last = 0;
            }
            else{
               last += 1;
            }

            escapeByte2 = queue[last];
            queue[last] = 0;
            currSize -= 1;
            if(last == 49){
               last = 0;
            }
            else{
               last += 1;
            }

            if(escapeByte2 == 1){
               dataByte1 = 255;
            } else if(escapeByte2 == 2){
               dataByte2 = 255;
            } else if(escapeByte2 ==3){
               dataByte1 = 255;
               dataByte2 = 255;
            }

            if(directionByte){
                targetPos = 30000 - (dataByte1 << 8) - dataByte2 ;
            }else{
                targetPos = (dataByte1 << 8) + dataByte2 + 30000;
            }

        }
        if(sendFlag){
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
            sendFlag = 0;
        }
*/
        upCount = TA0R;
        downCount = TA1R;
        absPos = absPos + upCount - downCount;

        TA0R = 0;
        TA1R = 0;
        static const int gain = 100;
        static const int limit = 2500;
        if(targetPos > absPos){
            freqInt = gain*(targetPos - absPos);
            if(freqInt >= limit){
                freqInt = limit;
            }
            TB0CCR2 = freqInt;
            TB0CCR1 = 0;
        }

        else
        {
            freqInt = gain*(absPos - targetPos);
            if(freqInt >= limit){
                freqInt = limit;
            }
            TB0CCR1 = freqInt;
            TB0CCR2 = 0;
        }

    }
}

#pragma vector = TIMER1_B0_VECTOR
__interrupt void TIMER1_ISR(void)
{
    // 255, UP1, UP0, DOWN1, DOWN0, ESCAPE
    // where 1 is most sig, 0 is least
    if(!sendFlag){
        upCount = TA0R;
        downCount = TA1R;
        TA0R = 0;
        TA1R = 0;
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
        sendFlag = 1;
    }

    // 255, UP1, UP0, DOWN1, DOWN0, ESCAPE
    // where 1 is most sig, 0 is least

}

#pragma vector = USCI_A1_VECTOR
__interrupt void USCI_A1_ISR(void)
{
    unsigned char RxByte = 0;

    RxByte = UCA1RXBUF;
    while(!(UCA1IFG & UCTXIFG)); //if currently transmitting, then loop on itself
    UCA1TXBUF = RxByte;

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
