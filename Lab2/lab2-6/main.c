#include <msp430.h> 


/**
 * main.c
 */
int main(void)
{
	WDTCTL = WDTPW | WDTHOLD;	// stop watchdog timer
	// Set up timer A to measure the length of time of a pulse from a rising edge to a falling edge.
	TB0CTL = MC_1;
	// Connect the timer output from the previous exercise to the input of this timer.

	// Using the debugger to check the measured 16-bit value.
	
	return 0;
}
