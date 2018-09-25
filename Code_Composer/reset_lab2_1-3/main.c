#include <msp430.h> 


/**
 * main.c
 */
int main(void)
{
	WDTCTL = WDTPW | WDTHOLD;	// stop watchdog timer
    P3OUT = 0; //CLEAR ALL registers used in lab 2
    PJOUT = 0;
    P3DIR = 0;
    PJDIR = 0;
    CSCTL2 = 0;
    CSCTL1 = 0; // make sure high freq select is off
    CSCTL3 = 0;
    P3SEL0 = 0;
    P3SEL1 = 0;
	return 0;
}
