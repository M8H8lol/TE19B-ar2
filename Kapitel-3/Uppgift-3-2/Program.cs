using System;

namespace Uppgift_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in en text, (usa)
            Console.Write("Vem vann fotbolls-VM för damer 2015?");
            string vinnare = Console.ReadLine();

            // Sanera inmatningen
            vinnare = vinnare.ToLower();

            // Kontrollera om rätt svar
            if (vinnare == "usa")
            {
                Console.WriteLine("Rätt svar!");
            }

            else
            {
                Console.WriteLine("Fel svar!");
            }
        }
    }
}

