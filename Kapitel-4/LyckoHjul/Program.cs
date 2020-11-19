using System;

namespace LyckoHjul
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren gissa ett tal 1-10
            Console.WriteLine("Var vänlig gissa ett tal mellan 1-10");
            int gissning = int.Parse(Console.ReadLine());

            // Slumpa fram ett tal 1-10
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 11);

            // Berätta för användaren vilket blev slumptalet
            Console.WriteLine($"Ditt slumptal är {slumptal}");

            // Berätta för användaren om man vann eller inte
            if (gissning == slumptal)
            {
                Console.WriteLine("Du gissade rätt! Bra jobbat!");
            }
            else
            {
                Console.WriteLine("Fel svar!");
            }
        }
    }
}
