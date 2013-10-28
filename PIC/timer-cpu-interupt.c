////////////////////////
// INTERUPT TIMER OPG.//
// Programmering, PIC.// 
// TEK, HOLMEN, 2013  //
// Jimmy schach       //
////////////////////////
#include <ISR.h>
#int_RTCC //interupt RTCC=REAL TIME CLOCK CONTROLLER

//TIMER INTERUPT REQUEST,(VOID)=DU KAN IKKE OVERF�RE PARAMETRE
void TIMER_isr(void)
{
   output_toggle(PIN_B0);
   DELAY_MS(100);
}
/*CPU INTERN CLOCK=4MHZ DIVIDERET MED 4 =1MHZ
CPU INTERN CLOCK I �S=1 DIVIDERET MED CPU INTERN CLOCK(1MHZ)=1�S
TIDEN EFTER PRESCALE=CPU INTERN CLOCK(1�S) GANGE RTCC_DIV_64(64)=64�S
TIDEN EFTER TIMEREN ER TALT OP(8BIT)=TIDEN EFTER 
PRESCALE GANGE 8 BIT(256)=16384MS
DVS. AT CPUEN BLIVER AFBRUDT CA. HVERT 16MS(16384MS) FOR AT KALDE 
FUNKTIONEN TIMER0_isr
*/
void main()
{
   setup_adc_ports(AN0);
   setup_timer_0(RTCC_INTERNAL|RTCC_DIV_64|RTCC_8_bit);
   enable_interrupts(INT_TIMER0);
   enable_interrupts(GLOBAL);
  
}
