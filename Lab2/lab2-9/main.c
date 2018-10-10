#include <msp430.h>


/**
 * main.c
 */
volatile unsigned char temp;

int main(void)
{
  WDTCTL = WDTPW + WDTHOLD;                 // Stop WDT

    //setting clock speed of DCO
    CSCTL0 = 0xA500; //clock password
    CSCTL1 = DCOFSEL0 + DCOFSEL1; // 8MHz
    //setting all clock sources to DCO
    CSCTL2 = SELM0 + SELM1 + SELA0 + SELA1 + SELS0 + SELS1;

    //setting P2.0 P2.1 as UART pins
    P2SEL0 &= ~(BIT1 + BIT0);
    P2SEL1 |= BIT1 + BIT0;

    //setting up UART0
    UCA0CTLW0 = UCSSEL0; //set source to SMCLK
    //UCBR bit is = 52
    UCA0CTLW0 = UCSSEL0;                    // Run the UART using ACLK
    UCA0MCTLW = UCOS16 + UCBRF0 + 0x4900;   // Baud rate = 9600 from an 8 MHz clock
    UCA0BRW = 52;

    //reference generator
    while(REFCTL0 & REFGENBUSY);              // If ref generator busy, WAIT
      REFCTL0 |= REFVSEL_0+REFON;               // Select internal ref = 1.5V
                                                // Internal Reference ON
    //  ADC10IE |=ADC10IE0;                       // enable the Interrupt request for a completed ADC10_B conversion

      __delay_cycles(400);                      // Delay for Ref to settle

    // ADC
    ADC10CTL0 |= ADC10ON + ADC10SHT_10;         // ADC ON + sampling time
    ADC10CTL1 |= ADC10CONSEQ_0 + ADC10SHP;     //single ch/conv + pulse sample mode
    ADC10CTL2 |= ADC10RES;        // 10-bit conversion results
    ADC10MCTL0 = ADC10INCH_10 + ADC10SREF_1;

    //timer b1.1
    TB1CTL |= TBSSEL0; //source = ACLK
    TB1CTL |= MC0; //up mode
    TB1CTL |= ID0 + ID1; //input divider 8
    TB1CCTL0 |= CCIE; //interrupt enable

    TB1EX0 |= TBIDEX2 +TBIDEX1 + TBIDEX0; //set divider to 8
    TB1CCR0 = 10000; //40ms , 25Hz


    //power NTC thermistor
    P2DIR |= BIT7;
    P2OUT |= BIT7;

    //setup adc analog ports
   // P3SEL0 |= BIT0 + BIT1 + BIT2;
   //P3SEL1 |= BIT0 + BIT1 + BIT2;

    //LEDS
    //3.4 3.5 3.6 3.7 J.0 J.1 J.2 J.3 as output
    P3DIR |=  BIT4 +BIT5 + BIT6 + BIT7;
    P3SEL1 &= ~(BIT4 + BIT5 + BIT6 + BIT7);
    P3SEL0 &= ~(BIT4 +BIT5 + BIT6 + BIT7);

    PJDIR |= BIT0 + BIT1 + BIT2 + BIT3;
    PJSEL1 &= ~(BIT0 + BIT1 + BIT2 + BIT3);
    PJSEL0 &= ~(BIT0 + BIT1 + BIT2 + BIT3);

    P3OUT &= ~(BIT4 +BIT5 + BIT6 + BIT7);
    PJOUT &= ~(BIT0 + BIT1 + BIT2 + BIT3);
    PJOUT |= BIT0; //LED 1 on;

    _EINT(); //global interrupt enable

    while(1)
    {
        ADC10CTL0 |= ADC10ENC + ADC10SC;
        while(ADC10CTL1 & ADC10BUSY);              //wait for conversion to finish
        temp = ADC10MEM0;

    }

return 0;
}

#pragma vector = TIMER1_B0_VECTOR
__interrupt void TIMER1_B0_ISR(void){
    while(!(UCA0IFG & UCTXIFG));
    UCA0TXBUF = temp;

    switch (temp)
    {
    case 68 : P3OUT = 0 ; PJOUT = BIT0; break;
    case 69 : P3OUT = 0; PJOUT = BIT0 + BIT1; break;
    case 70 : P3OUT = 0; PJOUT = BIT0 + BIT1 + BIT2; break;
    case 71 : P3OUT = 0; PJOUT = BIT0 + BIT1 + BIT2 + BIT3; break;
    case 72 : P3OUT = BIT4; PJOUT = BIT0 + BIT1 + BIT2 + BIT3; break;
    case 73 : P3OUT = BIT4 +BIT5; PJOUT = BIT0 + BIT1 + BIT2 + BIT3; break;
    case 74 : P3OUT = BIT4 +BIT5 + BIT6; PJOUT = BIT0 + BIT1 + BIT2 + BIT3; break;
    case 75 : P3OUT = BIT4 +BIT5 + BIT6 + BIT7; PJOUT = BIT0 + BIT1 + BIT2 + BIT3; break;


    }


    TB1CCTL0 &= ~(CCIFG);


}
