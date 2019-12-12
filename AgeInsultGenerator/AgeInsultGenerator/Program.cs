using System;

namespace AgeInsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterAge;
            String result = null;
            Console.WriteLine("Please enter an age so i may make fun of you!!");
            Console.WriteLine("If you call me a boomer you might die of old age.");
            enterAge = Convert.ToInt32(Console.ReadLine());

            //There will be under 12, between age 13 and 17
            //between age 18-25
            //age 26-35
            //36-45
            //45-54
            //55-62
            //and 62+

            if (enterAge <= 12)
            {
                result = "You are just a young punk.";
            }
            else if (enterAge > 12 && enterAge <= 17)
            {
                result = "Your generation is the problem";
            }
            else if (enterAge > 17 && enterAge <= 25)
            {
                result = "Get a job and pay some taxes hippie!";
            }
            else if (enterAge > 25 && enterAge <= 35)
            {
                result = "How's sitting at home with kids...";
            }
            else if (enterAge > 35 && enterAge <= 45)
            {
                result = "How's the grey hair coming.";

            }
        }
    }
}
