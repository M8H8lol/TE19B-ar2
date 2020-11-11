using System;

namespace Uppgift_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";

            while (answer != "china")
            {
                Console.WriteLine("Which country is the most populated?");

                answer = Console.ReadLine();

                if (answer == "china")
                {
                    Console.WriteLine("Rätt svar!");
                    break;
                }
                else
                {
                    Console.WriteLine("Fel svar, försök igen");
                }
            }
        }
    }
}
