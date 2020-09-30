using System;

namespace Projekt_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to quit? ");

            string answer = "";
            answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("Okay bye! ");
                Environment.Exit(0);
            }
            else if (answer == "no")
            {
                Console.WriteLine("Are you sure? ");
                answer = Console.ReadLine().ToLower();

                if (answer == "yes")
                {
                    Console.WriteLine("Ok, bye!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Okay, but I do.\nBye!");
                    Environment.Exit(0);
                }


            }
            else
            {
                Console.WriteLine("Invalid answer");
            }
        }
    }
}
