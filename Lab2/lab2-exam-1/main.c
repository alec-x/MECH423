#include <msp430.h> 

int main(void)
{
      WDTCTL = WDTPW | WDTHOLD; // stop watchdog timer
      CSCTL0_H = 0xA5;
      CSCTL1 |= DCOFSEL0 + DCOFSEL1;       // Set max. DCO setting =8MHz
      CSCTL2 = SELA_3 + SELS_3 + SELM_3;   // set ACLK = SMCLK = MCLK = DCO/8
      CSCTL3 = DIVA_3 + DIVS_3 + DIVM_3;   // set all dividers

      P3DIR |= BIT4;                       // P3.4 output
      P3SEL0 |= BIT4;                      // P3.4 options select
      TB1CCR0 = 200;                      // PWM Period clock = 1MHz, desired freq 500Hz, factor 2000
      TB1CCTL1 = OUTMOD_7;                 // CCR1 reset/set
      TB1CCR1 = 40;                      // CCR1 PWM duty cycle
      TB1CTL = TBSSEL_1 + MC_1;            //set up  timer B in up count mode with ACLK as source
      while(1);
    return 0;
}

