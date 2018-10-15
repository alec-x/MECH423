#include <msp430.h> 

unsigned volatile int ledOrder = 0;

/**
 * main.c
 */
int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer
    P4OUT = 0; //CLEAR registers
    P4SEL0 = 0;
    P4SEL1 = 0;
    P3SEL0 = 0;
    P3SEL1 = 0;

    // Set P4 as input with pullup-resistor
    P4DIR &= ~BIT0; //Set P4 direction to input for P4.0
    P4REN |= BIT0; //enable pull-up resistors
    P4OUT |= BIT0; // set as pullup

    // Enable local interrupt
    P4IE |= BIT0;
    P4IFG = 0;
    // Set P4.0 to get interrupted from a rising edge (i.e. an interrupt occurs when the user press the button)
    P4IES = 1;

    // Configure P3.7 as an output (this is connected to LED8)
    P3DIR |= BIT4 + BIT5 + BIT6 + BIT7; //Set P3 direction to output for P3.4,3.5,4.6, 1b
    PJDIR |= BIT0 + BIT1 + BIT2 + BIT3; //Set PJ direction to output for PJ.0,J.1,J.2, 1b

    P3OUT = 0;

    // Enable global interrupts
    __enable_interrupt();
    return 0;
}

// Write an interrupt service routine to toggle LED8 when S1 provides a rising edge
#pragma vector=PORT4_VECTOR
__interrupt void toggle_LED8(void){
    P3OUT ^= BIT7;
    P4IFG &= ~BIT0;
    switch(ledOrder){
        case (0):
            PJOUT = BIT0;
            P3OUT = 0;
            break;
        case (1):
            PJOUT = BIT1;
            P3OUT = 0;
            break;
        case (2):
            PJOUT = BIT2;
            P3OUT = 0;
            break;
        case (3):
            PJOUT = BIT3;
            P3OUT = 0;
            break;
        case (4):
            PJOUT = 0;
            P3OUT = BIT4;
            break;
        case (5):
            PJOUT = 0;
            P3OUT = BIT5;
            break;
        case (6):
            PJOUT = 0;
            P3OUT = BIT6;
            break;
        case (7):
            PJOUT = 0;
            P3OUT = BIT7;
            break;
    }
    if(ledOrder == 7){
        ledOrder = 0;
    } else{
        ledOrder++;
    }
}
