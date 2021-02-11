using System;
using System.IO;

namespace Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presentera programmet
            Console.WriteLine("Program för att hitta länder matchande sökterm.");
            Console.WriteLine("Program listar land och landskod");

            // Läs in alla rader i textfilen, om det finns
            if (File.Exists("countries.csv"))
            {
                // Läser in alla rader
                string[] rader = File.ReadAllLines("countries.csv");

                // Ber användaren om sökterm
                Console.WriteLine("Ange sökterm (avsluta med return): ");
                string sökterm = Console.ReadLine();

                // Loopa igenom alla rade
                foreach (var rad in rader)
                {
                    // Söka i den röda fältet
                    // Console.WriteLine(rad); // rad är ens tring
                    string[] delar = rad.Split(',');
                }

            }
            else
            {
                Console.WriteLine("Avbryter! Filen countries.csv finns inte.");
            }
        }
    }
}
