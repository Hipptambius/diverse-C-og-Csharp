#include <opg4.h>
int y=0;
int16 del=50;
int lys=0;
void main()
{
   while (TRUE)
   {
      if (input(PIN_A4) == 0) //trykket ned
      {
      y=1;
      }
      if (input(PIN_A4) == 1 && y == 1) //sluppet tasten
         {
         y=0;
         if (lys==0)
         {
         lys=1;
         }
         else
         {
         lys=0;
         }
         }

            if (lys==1)
            {
            output_high(PIN_B0);
            delay_ms(del);
            output_low(PIN_B0);
            delay_ms(del);
            output_high(PIN_B1);
            delay_ms(del);
            output_low(PIN_B1);
            delay_ms(del);
            output_high(PIN_B2);
            delay_ms(del);
            output_low(PIN_B2);
            output_high(PIN_B3);
            delay_ms(del);
            output_low(PIN_B3);
            delay_ms(del);
            }   
   }

}
