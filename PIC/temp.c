//Jimmy schach
//OPGAVE I C, TEK, HOLEM, 2013
//TÆLLER TIL 8 BINÆRT OG GEMMER I EEPROM
#include <temp.h>
int y=0;
int x=4;

void lys(int a,int b,int c,int d) //diode output
{
   output_bit(PIN_B0,a);
   output_bit(PIN_B1,b);
   output_bit(PIN_B2,c);
   output_bit(PIN_B3,d);
}
int tast() //tæller op ved return værdien
{
int q=1;
   while (q == 1)
   {
      if (input(PIN_A4) == 0) //trykket ned
      {
         y=1;
      }
      if (input(PIN_A4) == 1 && y == 1) //sluppet tasten
      {
         y=0;
         q = 0;      
      }
   
   }
return 1;
}


void main()
{
   while (TRUE)
   {  
      x=read_eeprom(20); // læser fra eeprom
      delay_ms(100);
      
      if (x==0)
      {
         lys(0,0,0,0);
      }
      if (x==1)
      {
         lys(1,0,0,0);   
      }
      if (x==2)
      {
         lys(0,1,0,0);   
      }
      if (x==3)
      {
         lys(1,1,0,0);   
      }
      if (x==4)
      {
         lys(0,0,1,0);   
      }
      if (x==5)
      {
         lys(1,0,1,0);   
      }
      if (x==6)
      {
         lys(0,1,1,0);   
      }
      if (x==7)
      {
         lys(1,1,1,0);   
      }
      if (x==8)
      {
         lys(0,0,0,1);   
      }
      if (x>8)
      {
         x=0;
         lys(0,0,0,0);
      }
      x = x+tast();
 
      write_eeprom(20,x); //skriver til eeprom
      delay_ms(100);      
   }
}   
