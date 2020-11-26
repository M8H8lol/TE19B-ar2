using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be om en text
            Console.Write("Ange en text: ");
            string text = Console.ReadLine();

            // Dela upp texten i separata ord
            string[] orden = text.Split(' ');

            // Loopa igenom arrayen
            /*for (int i = 0; i < orden.Length; i++)
            {
                Console.WriteLine($"Ord {i + 1}: {orden[i]}");
            }
            */

            // ALternativ 2 - foreach
            foreach (var ord in orden)
            {
                Console.WriteLine(ord);
            }

            // Skriv ut antalet ord
            Console.WriteLine($"Antal ord: {orden.Length}");
        }
    }
}
