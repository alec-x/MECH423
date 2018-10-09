#include <msp430.h> 


/**
 * main.c
 */
int main(void)
{
	WDTCTL = WDTPW | WDTHOLD;	// stop watchdog timer
	// set dco clock to 1MHz
    CSCTL1 |= DCOFSEL0 + DCOFSEL1;       // Set max. DCO setting =8MHz
    CSCTL2 = SELA_3 + SELS_3 + SELM_3;   // set ACLK = SMCLK = MCLK = DCO/8
    CSCTL3 = DIVA_3 + DIVS_3 + DIVM_3;   // set all dividers

	P2DIR |= BIT7; // configure P2 to be output
	
	//Configure timer interrupt
    P3DIR |= BIT4;                       // P3.4 output
    P3SEL0 |= BIT4;                      // P3.4 options select
    TB1CCR0 = 2000;                      // PWM Period clock = 1MHz, desired freq 500Hz, factor 2000
    TB1CCTL1 = OUTMOD_7;                 // CCR1 reset/set
    TB1CCR1 = 500;                      // CCR1 PWM duty cycle
    TB1CTL = TBSSEL_1 + MC_1;            //set up  timer B in up count mode with ACLK as source

	// sample from PA12,13,14 = P2.4-2.6
	ADC10CTL0 &= ~ADC10ENC; //settings can only be changed when this is true
    ADC10CTL0 = ADC10SHT_0 + ADC10ON;// 16ADCclks, ADC ON
    ADC10CTL0 &= ~ADC10MSC; //make sure MSC is off so we get chance to record data in vars without direct memory access
    ADC10CTL1 = ADC10CONSEQ_1;     // multiple channel single sequence
    ADC10CTL2 &= ~ADC10RES;                   // 8-bit resolution
    ADC10MCTL0 = ADC10_INCH_14; // sample from 14 -> 0, must reset ADC10ENC at x = 12

    _EINT(); //global interrupt enable
    while(1)
    {

      while (ADC10CTL1 & BUSY);               // Wait if ADC10 core is active
      ADC10CTL0 |= ADC10ENC + ADC10SC;        // Sampling and conversion start
      __no_operation();                       // BREAKPOINT; check ADC_Result
    }


	return 0;
}

#pragma vector = TIMER0_A1_VECTOR
__interrupt void TIMER0_ISR(void)
{
}
}
