using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Opgave i C#
// Jimmy schach
// TEK, HOLMEN, 2013

namespace console_temp
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                string tast;
                Console.WriteLine("Tast 1 for SIN eller 2 for COS");
                Console.WriteLine("Tast q for at afbryde");
                tast = Console.ReadLine();
                switch (tast)
                {
                    case "1":
                        {
                            sin();
                            break;
                        }
                    case "2":
                        {
                            cos();
                            break;
                        }
                    case "q":
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Vælg enten SIN eller COS");
                            break;
                        }
                }
            }

        }
        static void sin()
        {
            double SIN = 0;
            int y = 0;
            int x = 0;
            bool p = false;

            while (p == false)
            {

                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).KeyChar == Convert.ToChar("q"))
                    {
                        p = true;
                    }

                }
                y = 0;
                for (x = 0; x < 360; x = x + 5)
                {
                    SIN = 30 * Math.Sin(x * Math.PI / 180) + 37;
                    Console.WriteLine("*".PadLeft(Convert.ToInt32(SIN)).PadRight(y));
                    Thread.Sleep(10);
                    y++;
                }

            }

        }
        static void cos()
        {
            double COS = 0;
            int y = 0;
            int x = 0;
            bool p = false;

            while (p == false)
            {

                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).KeyChar == Convert.ToChar("q"))
                    {
                        p = true;
                    }

                }
                y = 0;
                for (x = 0; x < 360; x = x + 5)
                {
                    COS = 30 * Math.Cos(x * Math.PI / 180) + 37;
                    Console.WriteLine("*".PadLeft(Convert.ToInt32(COS)).PadRight(y));
                    Thread.Sleep(10);
                    y++;
                }

            }

        }

    }

}
