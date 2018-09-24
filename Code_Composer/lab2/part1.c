#include <msp430.h> 


/**
 * main.c
 */
int main(void)
{
    // |= REG_NAME sets the bit at that bit. REG_NAME + REG_NAME_2 sets the bit at those 2 bits.

	WDTCTL = WDTPW | WDTHOLD;	// stop watchdog timer
	CSCTL2 |= SELS_1 + SELS_2; //set SMCLK to DCO, 011b
	CSCTL1 &= ~DCORSEL; // make sure high freq select is off
	CSCTL1 |= DCOFSEL_0 + DCOFSEL_1; // set DCO to 8MHz, 11b
	CSCTL3 |= DIVS_0 + DIVS_2; // set SMCLK divisor to 32, 101b
	P3DIR |= BIT4; //Set P3 direction to output for P3.4, 1b
	P3SEL0 |= BIT4;
	P3SEL1 |= BIT4;

	while(1){

	}


	return 0;
}
