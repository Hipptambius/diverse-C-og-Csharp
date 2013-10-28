#include <ISR.h>
#int_RTCC
void TIMER_isr(void)
{
   output_toggle(PIN_B0);
   DELAY_MS(10);
}

void main()
{
   setup_adc_ports(AN0);
   setup_timer_0(RTCC_INTERNAL|RTCC_DIV_64|RTCC_8_bit);
   enable_interupts(INT_TIMER0);
   enable_interupts(GLOBAL);
  
}
