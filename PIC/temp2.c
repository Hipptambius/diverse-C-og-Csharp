#include <temp2.h>
#include <ds1621.c>
//RS232 KRYDS MELLEM 2 BOARDS, UDLÆSNING OG INDLÆSNING
//TEK, HOLMEN 2013
//JIMMY SCHACH
int x=0;


void main()
{
   setup_adc(ADC_CLOCK_INTERNAL);
   setup_adc_ports(ALL_ANALOG);
   set_adc_channel(0);
    int in;
   while (true)
   {
      //Udlæsning fra analog potmeter
      int A=READ_ADC();
      
      //udlæsning til rs232
     for (x=0;x<10;x++)
      {
         printf("%u\n\r",A);
         delay_ms(300); 
      }     
      //modtag input fra rs232     
     
      for (x=0;x<10;x++)
      {
         if(kbhit()) 
         {
            in = getch();
         }
      }
      //printf((int)in);
      output_toggle(PIN_C2);
      delay_ms(in);
      output_toggle(PIN_C2);
      delay_ms(in);
      output_toggle(PIN_C2);
      delay_ms(in);
      output_toggle(PIN_C2);
      delay_ms(in);
      output_toggle(PIN_C2);
      delay_ms(in);
      
   }


}
