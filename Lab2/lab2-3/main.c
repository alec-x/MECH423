#include <msp430.h> 


/**
 * main.c
 */
int main(void)
{
	WDTCTL = WDTPW | WDTHOLD;	// stop watchdog timer
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
	// Set P4.0 to get interrupted from a rising edge (i.e. an interrupt occurs when the user lets go of the button)
	P4IES &= ~BIT0;

	// Configure P3.7 as an output (this is connected to LED8)
	P3DIR |= BIT7;

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
}
