////////////////////////
// ADC-Løbelys OPG.   //
// Programmering, PIC.// 
// TEK, HOLMEN, 2013  //
// Jimmy schach       //
////////////////////////
#include <ADCmain.h>

void main()
{
setup_adc(ADC_CLOCK_INTERNAL);
setup_adc_ports(ALL_ANALOG);
set_adc_channel(0);

   while (TRUE)
   {
   //Udlæsning fra analog port
   int32 del=READ_ADC();
   
   //Løbelys
   output_high(PIN_B0);
   output_high(PIN_C2);
   delay_ms(del);
   output_low(PIN_B0);
   output_low(PIN_C2);
   delay_ms(del);
   output_high(PIN_B1);
   output_high(PIN_C2);
   delay_ms(del);
   output_low(PIN_B1);
   output_low(PIN_C2);
   delay_ms(del);
   output_high(PIN_B2);
   output_high(PIN_C2);
   delay_ms(del);
   output_low(PIN_B2);
   output_low(PIN_C2);
   delay_ms(del);
   output_high(PIN_B3);
   output_high(PIN_C2);
   delay_ms(del);
   output_low(PIN_B3);
   output_low(PIN_C2);
   delay_ms(del);
   }
}
