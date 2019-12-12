using System;

namespace FahrenheitToCeliusConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp8AM;
            int temp8AMtoCelsius;
            Console.WriteLine("Please enter a temp at 8 AM");
            temp8AM = Convert.ToInt32(Console.ReadLine());

            if (temp8AM <= 32)
            {
                Console.WriteLine("It is freezing!");
            }
            else if (temp8AM >= 100)
            {
                Console.WriteLine("It is Beautiful!");
            }

            int temp12PM;
            int temp12PMtoCelsius;
            Console.WriteLine("Please enter a temp at 12 PM");
            temp12PM = Convert.ToInt32(Console.ReadLine());

            if (temp12PM <= 32)
            {
                Console.WriteLine("It is cold!");
            }
            else if (temp12PM >= 100)
            {
                Console.WriteLine("It is hot!");
            }

            int temp5PM;
            int tmep5PMtoCelsius;
            Console.WriteLine("Please enter a temp at 5 PM");
            temp5PM = Convert.ToInt32(Console.ReadLine());

            if (temp5PM <= 32)
            {
                Console.WriteLine("It is freezing!");
            }
            else if (temp5PM >= 100)
            {
                Console.WriteLine("It is miserable!");
            }

            // temp8AMtoCelsius = the formula I gave you.

        }
    }
}
