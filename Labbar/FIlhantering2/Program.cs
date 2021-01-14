using System;
using System.IO;

namespace FIlhantering2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Filnamnet
            string filnamn = "./animals.txt";

            // Läs in alla rader
            string[] rader = File.ReadAllLines(filnamn);

            // Loopa igenom arrayen
            // GÅ igenom rad för rad
            int counter = 1;
            foreach (var rad in rader)
            {
                Console.WriteLine(counter + "" + rad);
                counter++;
            }

            Console.WriteLine($"hittade {counter + 1} djur");
        }
    }
}
