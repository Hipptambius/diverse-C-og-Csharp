#include <LCD-OPGAVE1.h>
#include <string.h>

//LCD setup
#define LCD_ENABLE_PIN  PIN_A1
#define LCD_RS_PIN      PIN_A3
#define LCD_RW_PIN      PIN_A2
#define LCD_POWER       PIN_A4


#define LCD_DATA4       PIN_D0
#define LCD_DATA5       PIN_D1
#define LCD_DATA6       PIN_D2
#define LCD_DATA7       PIN_D3

#include <rene_lcd.c>


void main()
{
   lcd_init();
   printf(lcd_putc,"Jimmy er gud");
   while (TRUE)
   {
   }


}
