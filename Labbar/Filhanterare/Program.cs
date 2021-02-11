using System;
using System.IO;

namespace Filhanterare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriva till en textfil
            File.WriteAllText("fil1.txt", "Nu snöar det igen! Kul!");

            string allText = File.ReadAllText("./Filhanterare.csproj");

            // Skriv ut innehållet
            Console.WriteLine($"Innehållet: \n{allText}");

            // Fråga användaren om filnamn
            Console.Write("Ange filnamn: ");
            string filnamn = Console.ReadLine();

            // Kontrollera att filen finns!
            if (File.Exists(filnamn))
            {
                // LÄs in allt
                string texten = File.ReadAllText(filnamn);
                Console.Write(texten);
            }
            else
            {
                Console.WriteLine($"Hittade inte filen {filnamn}");
            }

        }
    }
}
