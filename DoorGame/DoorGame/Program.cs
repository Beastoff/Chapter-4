using System;

namespace DoorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;
            Console.WriteLine("Pick a door 1, 2, or 3");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == 1)
            {
                Console.WriteLine("You win a brand new car!");
            }
            else if (userEntry == 2)
            {
                Console.WriteLine("You win a new house!");
            }
            else if (userEntry == 3)
            {
                Console.WriteLine("You win a new wife!");
            }
            else
                Console.WriteLine("You are dumb");
        }   

    }
}
