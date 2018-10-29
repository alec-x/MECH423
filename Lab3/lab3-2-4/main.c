#include <msp430.h>
#include <stdio.h>

/**
 * main.c
 */
unsigned int voltage = 0;

int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer
    CSCTL0_H = 0xA5;
    CSCTL1 = DCOFSEL0 + DCOFSEL1;
    CSCTL2 = SELM0 + SELM1 + SELA0 + SELA1 + SELS0 + SELS1;

    //Configure LED
    PJDIR |= BIT0 + BIT1 + BIT2;

    //Configure A12 as Analog in
    P3SEL0 |= BIT0;
    P3SEL1 |= BIT0;

    //Configure ADC
    ADC10CTL0 = ADC10SHT_2 + ADC10ON;                         // 16ADCclks, ADC ON
    ADC10CTL1 = ADC10CONSEQ_0 + ADC10SHP + ADC10SSEL_1;       // single channel single sequence
    ADC10CTL2 |= ADC10RES;                                    // 10-bit resolution, shift when read
    ADC10MCTL0 |= ADC10INCH_12; //channel 12

    _EINT(); //global interrupt enable

    //Configure Duty cycle (A1 and A2)
    P1DIR |= BIT4 + BIT5;                       // P1.4, 1.5 output
    P1SEL0 |= BIT4 + BIT5;                      // P1.4, 1.5 options select
    TB0CCTL1 = OUTMOD_7;                 // CCR1 reset/set
    TB0CCTL2 = OUTMOD_7;                 // CCR2 reset/set
    TB0CCR1 = 0;                      // CCR1 PWM duty cycle, PWM Period clock = 8MHz
    TB0CCR2 = 0;                      // CCR1 PWM duty cycle, PWM Period clock = 8MHz
    TB0CTL = TBSSEL_1 + MC_2;            //set up  timer B in up count mode with ACLK as source

    while(1){
        ADC10CTL0 |= ADC10ENC + ADC10SC;        // Start sampling
        while (ADC10CTL1 & BUSY);               // Wait if ADC10 core is active

        voltage = ADC10MEM0 << 6;
        voltage -= 10;

        TB0CCR1 = voltage;
        ADC10CTL0 &= ~(ADC10ENC + ADC10SC);
    }

    return 0;
}
