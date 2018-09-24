#include <msp430.h> 


/**
 * main.c
 */
int main(void)
{
    //PJ: BIT0 = LED1 BIT1 = LED2 BIT2 = LED3 BIT3 = LED4
    //P3: BIT4 = LED5 BIT5 = LED6 BIT6 = LED7 BIT7 = LED8
	WDTCTL = WDTPW | WDTHOLD;	 // stop watchdog timer
	P3DIR |= BIT4 + BIT5 + BIT6 + BIT7; //Set P3 direction to output for P3.4,3.5,4.6, 1b
	PJDIR |= BIT0 + BIT1 + BIT2 + BIT3; //Set PJ direction to output for PJ.0,J.1,J.2, 1b
	P3OUT = 0; //CLEAR ALL LED'S
	PJOUT = 0;
	//CREATE 10010011 PATTERN
	PJOUT |= BIT0 + BIT3;
	P3OUT |= BIT6 + BIT7;
	//MAKE 0'S IN PATTERN BLINK
	while(1){
	    PJOUT ^= BIT1 + BIT2;
	    P3OUT ^= BIT4 + BIT5;
	    __delay_cycles(100000);
	}
}
