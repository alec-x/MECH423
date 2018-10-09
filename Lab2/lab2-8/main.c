#include <msp430.h>
volatile long intDeg; //in celsius

int main(void)
{
  WDTCTL = WDTPW + WDTHOLD;                 // Stop WDT

  // Configure ADC10 - Pulse sample mode; ADC10SC trigger
  ADC10CTL0 = ADC10SHT_8 + ADC10ON;         // 16 ADC10CLKs; ADC ON,temperature sample period>30us
  ADC10CTL1 = ADC10SHP + ADC10CONSEQ_0;     // s/w trig, single ch/conv
  ADC10CTL2 = ADC10RES;                     // 10-bit conversion results
  ADC10MCTL0 = ADC10SREF_1 + ADC10INCH_10;  // ADC input ch A10 => temp sense

  // Configure internal reference
  while(REFCTL0 & REFGENBUSY);              // If ref generator busy, WAIT
  REFCTL0 |= REFVSEL_0+REFON;               // Select internal ref = 1.5V
                                            // Internal Reference ON
  ADC10IE |=ADC10IE0;                       // enable the Interrupt request for a completed ADC10_B conversion

  __delay_cycles(400);                      // Delay for Ref to settle


  while(1)
  {
    ADC10CTL0 |= ADC10ENC + ADC10SC;        // Sampling and conversion start

    __bis_SR_register(LPM4_bits + GIE);     // LPM4 with interrupts enabled
    __no_operation();

  }
}

// ADC10 interrupt service routine
#pragma vector = ADC10_VECTOR
__interrupt void ADC_ISR(void)
{
    intDeg = ADC10MEM0;
}

