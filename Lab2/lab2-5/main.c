#include <msp430.h> 

int main(void)
{
	WDTCTL = WDTPW | WDTHOLD;	// stop watchdog timer
	  WDTCTL = WDTPW + WDTHOLD;            // Stop WDT
	  CSCTL0_H = 0xA5;
	  CSCTL1 |= DCOFSEL0 + DCOFSEL1;       // Set max. DCO setting =8MHz
	  CSCTL2 = SELA_3 + SELS_3 + SELM_3;   // set ACLK = SMCLK = MCLK = DCO/8
	  CSCTL3 = DIVA_3 + DIVS_3 + DIVM_3;   // set all dividers

	  P3DIR |= BIT4;                       // P3.4 output
	  P3SEL0 |= BIT4;                      // P3.4 options select
	  TB1CCR0 = 2000;                      // PWM Period clock = 1MHz, desired freq 500Hz, factor 2000
	  TB1CCTL1 = OUTMOD_7;                 // CCR1 reset/set
	  TB1CCR1 = 1000;                      // CCR1 PWM duty cycle
	  TB1CTL = TBSSEL_1 + MC_1;            //set up  timer B in up count mode with ACLK as source

	  P3DIR |= BIT5;
      P3SEL0 |= BIT5;
      TB1CCTL2 = OUTMOD_7;                 // CCR2 reset/set
      TB1CCR2 = 500;                      // CCR2 PWM duty cycle 25%

	return 0;
}

