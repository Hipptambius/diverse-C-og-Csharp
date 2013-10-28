#include <RStmp.h>
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
         printf("%u  -  %u \n\r",A,in);
         delay_ms(300); 
      }     
      //modtag input fra rs232     
     
      for (x=0;x<10;x++)
      {
         if(kbhit()) { in = getch();}
      
         if (in<50)
         {
            output_high(PIN_B0);
         }
         else
         {
            output_low(PIN_B0);
         }
      }
      
   }


}
