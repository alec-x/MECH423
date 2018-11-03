#include <msp430.h>


/**
 * main.c
 */
volatile unsigned char circBuf[5];
volatile unsigned int start = 0;
volatile unsigned int end = 0;
volatile unsigned int mergedNum = 40000;
unsigned int mode = 2; //
unsigned int ADC_Result;
unsigned int i;
unsigned int freq;

void setup(void);
void setFreq(void);
void restoreDataBytes(void);

int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer

    setup();

    UCA1IE |= UCRXIE;                         // enable RX interrupt
    __enable_interrupt();                     // Enable interrupt

    unsigned volatile int a = 0x61;

    while(1){
        mode = circBuf[1];

        if(end == 5){
            mergedNum = (circBuf[2]<<8)|circBuf[3];
            circBuf[2] = 0;
            circBuf[3] = 0;
            end = 0;
        }
    }
}

/**
 * set up UART, PWM and ADC
 */
void setup(void){
    //Outputs SMCLK on PJ.0, MCLK on PJ.1, and ACLK on PJ.2
//    PJDIR |= BIT0 + BIT1 + BIT2;
//    PJSEL0 |= BIT0 + BIT1 + BIT2 + BIT4 + BIT5;

    CSCTL0_H = 0xA5;
    CSCTL1 &= ~DCORSEL;
    CSCTL1 |= DCOFSEL0 + DCOFSEL1; //Set Max DCO settings = 8 MHz 363800 Hz
    CSCTL2 |= SELA_3 + SELS_3 + SELM_3; // set XT1 as source for ACLK, SMCLK, MCLK
    CSCTL3 |= DIVA_0 + DIVS_3 + DIVM_0; // 8 MHz -> 1 MHz
    CSCTL4 |= XT1DRIVE_3 + XTS;
    CSCTL4 &= ~XT1OFF;

    // Configure UART pins P2.5 --> UCA1TXD; P2.6 UCA1RXD
    P2SEL0 &= ~(BIT5+BIT6);
    P2SEL1 |= BIT5 + BIT6;
    // Configure UART 1
    UCA1CTL1 |= UCSWRST + UCRXEIE + UCBRKIE;

    UCA1CTL1 |= UCSSEL_2; // Select ACLK as UCBRCLK
    UCA1BR0 |= 6;
    UCA1MCTLW |= 0x2000 + UCBRF_8 + UCOS16;
    UCA1IE |= UCRXIE; // Enable RX interrupt

    // Configure pins for PWM
    P1DIR |= BIT4 + BIT5; // output
    P1SEL0 |= BIT4 + BIT5; // option select
    P1SEL1 &= ~(BIT4 + BIT5); // option select

    // Timer B
    TB0CCTL1 = OUTMOD_7;
    TB0CCR1 = 60000;
    TB0CCTL2 = OUTMOD_5;
    TB0CCR2 = 60000;
    TB0CTL |= TBSSEL_1 + MC_2 + TBCLR;   // ACLK; continuous; clear TAR

//    TB0CTL |= TBSSEL_2 + MC_2 + ID_3 + TBCLR;   // Select SMCLK as source;

    // Configure ADC
    P3SEL1 &= ~BIT0;
    P3SEL0 |= BIT0;

//    ADC10CTL0 |= ADC10SHT_2 + ADC10ON + ADC10MSC;        // ADC10ON, S&H=16 ADC clks
//    ADC10CTL1 |= ADC10SHP + ADC10SSEL_2;                    // ADCCLK = MCLK; sampling timer
//    ADC10CTL1 |= ADC10CONSEQ_2; // repeated single channel
//    ADC10CTL2 |= ADC10RES;                    // 10-bit conversion results
//    ADC10MCTL0 |= ADC10INCH_12;                // A12 ADC input select; Vref=AVCC
//    ADC10IE |= ADC10IE0;                      // Enable ADC conv complete interrupt

    UCA1CTL1 &= ~UCSWRST;                     // release from reset
}

void restoreDataBytes(void){
    if((circBuf[4] & BIT0) == BIT0)
        circBuf[3] = 255;
    if((circBuf[4] & BIT1) == BIT1)
        circBuf[2] = 255;
}

void setFreq(void){
    switch(mode){
    case 0: TB0CCTL1 = OUTMOD_7;
            TB0CCTL2 = OUTMOD_5;
            TB0CCR1 = freq*256;
            TB0CCR2 = freq*256;
            break;
    case 1: TB0CCTL1 = OUTMOD_5;
            TB0CCTL2 = OUTMOD_7;
            TB0CCR1 = freq*256;
            TB0CCR2 = freq*256;
            break;

    case 2: TB0CCTL1 = OUTMOD_7;
            TB0CCTL2 = OUTMOD_5;
            TB0CCR1 = ADC_Result * 64;
            TB0CCR2 = ADC_Result * 64;
            break;
    case 3: TB0CCTL1 = OUTMOD_5;
            TB0CCTL2 = OUTMOD_7;
            TB0CCR1 = ADC_Result * 64;
            TB0CCR2 = ADC_Result * 64;
            break;
    default: break;
    }
}

#pragma vector = USCI_A1_VECTOR
__interrupt void USCI_A1_ISR(void){
    circBuf[end] = UCA1RXBUF;       // Vector 2 - RXIFG
    UCA1TXBUF = circBuf[end];
    end++;
    if (end == 5){
        end = 0;
        restoreDataBytes();
    }
    mode = circBuf[1];
    freq = circBuf[2];
    setFreq();
    UCA1IV &= ~UCRXIFG;
}

// ADC10 interrupt service routine
#pragma vector=ADC10_VECTOR
__interrupt void ADC10_ISR(void){
    switch(__even_in_range(ADC10IV,12))
    {
    case  0: break;                          // No interrupt
    case  2: break;                          // conversion result overflow
    case  4: break;                          // conversion time overflow
    case  6: break;                          // ADC10HI
    case  8: break;                          // ADC10LO
    case 10: break;                          // ADC10IN
    case 12: ADC_Result = ADC10MEM0;
             setFreq();
             break;                          // Clear CPUOFF bit from 0(SR)
    default: break;
    }
}
