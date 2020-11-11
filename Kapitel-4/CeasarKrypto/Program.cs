﻿using System;

namespace CeasarKrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ange en text
            Console.Write("Ange en text ");
            string text = Console.ReadLine();

            // Loopa igenom inmatad text bokstav för bokstav
            int textLängd = text.Length;
            Console.WriteLine($"Texten är {textLängd} tecken lång");

            // Låter användaren skriva in nyckeln angående hur många steg man ska hoppa fram i alfabetet
            Console.WriteLine("Var vänlig mata in en nyckel mellan 1-9");
            string nyckelString = Console.ReadLine();

            // Säkerställa att vi får in ett tal
            int nyckel = 0;
            int.TryParse(nyckelString, out nyckel);
            while (!int.TryParse(nyckelString, out nyckel))
            {
                Console.Write("Du måste mata in ett tal! Ange en nyckel (1-9): ");
                nyckelString = Console.ReadLine();
            }

            // Loopa igenom bokstav för bokstav
            string krypteradText = "";
            for (int i = 0; i < textLängd; i++)
            {
                Console.WriteLine($"Loop nr {i}");

                // Plocka ut bokstav på position i
                char bokstav = text[i];
                Console.WriteLine($"Bokstaven på position {i} är {bokstav}");

                // ASCII-värdet för ett tecken
                int ascii = (int)bokstav;
                Console.WriteLine($"Bokstaven {bokstav} har ASCII-värdet {ascii}");

                // Ceaser kryptering
                ascii += nyckel;

                // Plocka ut motsvarande tecken enligt ASCII tabellen
                char krypteradBokstav = (char)ascii;
                Console.WriteLine($"Bokstaven {bokstav} krypteras till {krypteradBokstav}");

                // Samla ihop bokstäverna 
                krypteradText += krypteradBokstav.ToString();
            }

            // Skriv ut krypterade texten
            Console.WriteLine($"Det krypterade meddelandet: {krypteradText}");
        }
    }
}