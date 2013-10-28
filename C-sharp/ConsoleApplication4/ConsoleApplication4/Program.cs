using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            Console.WriteLine("Indtast det første tal du vil sammenligne");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast det andet tal du vil sammenligne");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Det højeste tal er");
            Console.WriteLine(Math.Max(a, b));
        }
    
    }

}
