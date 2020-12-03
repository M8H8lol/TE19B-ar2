using System;

namespace Uppgift_5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening");

            string mening = Console.ReadLine();

            string[] ord = mening.Split(' ');

            foreach (var ordet in ord)
            {
                Console.WriteLine(ordet);
            }
        }
    }
}
