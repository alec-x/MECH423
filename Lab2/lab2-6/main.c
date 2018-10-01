#include <msp430.h> 

unsigned int time1 = 0;
unsigned int time2 = 0;
unsigned int diff = 29;

int main(void)
{
    // LAB 5 SECTION TO PLUG INTO LAB 6
    WDTCTL = WDTPW | WDTHOLD; // stop watchdog timer
    CSCTL0_H = 0xA5;
    CSCTL1 |= DCOFSEL0 + DCOFSEL1;       // Set max. DCO setting =8MHz
    CSCTL2 = SELA_3 + SELS_3 + SELM_3;   // set ACLK = SMCLK = MCLK = DCO/8
    CSCTL3 = DIVA_3 + DIVS_3 + DIVM_3;   // set all dividers

    P3DIR |= BIT4;                       // P3.4 output
    P3SEL0 |= BIT4;                      // P3.4 options select
    TB1CCR0 = 2000;                      // PWM Period clock = 1MHz, desired freq 500Hz, factor 2000
    TB1CCTL1 = OUTMOD_7;                 // CCR1 reset/set
    TB1CCR1 = 500;                      // CCR1 PWM duty cycle
    TB1CTL = TBSSEL_1 + MC_1;            //set up  timer B in up count mode with ACLK as source

    // LAB 6 SECTION

    P1DIR &= ~(BIT0 + BIT1); // set P1.0 for TA0.1 Capture and Control Input
    P1SEL0 |= BIT0 + BIT1;
    P1SEL1 &= ~(BIT0 + BIT1);

    TA0CTL = TASSEL_2 + MC_2;
    TA0CCTL1 = CM_1 + CAP + SCS + CCIS_0; //CM_1 is rising edge
    TA0CCTL2 = CM_2 + CAP + SCS + CCIS_0 + CCIE;// CM_2 is falling edge

    _EINT(); //global interrupt enable

    while(1){
        __no_operation();
    }
}

#pragma vector = TIMER0_A1_VECTOR
__interrupt void TIMER0_ISR(void)
{
    time1 = TA0CCR1;
    time2 = TA0CCR2;
    diff = time2 - time1;
    __no_operation();
    TA0CCTL2 &= ~CCIFG;
}

