using System;
using System.IO;

namespace Exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Osäker metod att konvertera till int
            int talet = int.Parse(Console.ReadLine());

            // Be om heltal
            // Console.Writeline("Ange ett tal 1-100");
            // int.TryParse(Console.Readline());

            Console.WriteLine("Vilket bord vill du ändra på?");
            while (!int.TryParse(Console.Readline(), out svar))
            {
                Console.WriteLine("Icke giltigt bordsnummer, vg försök igen");
            }
            int bordNr = ReadInt();
            Console.WriteLine($"Du valde bord {bordNr}");
        }

        static int ReadInt()
        {
            int svar = 0;
            while (!int.TryParse(Console.Readline(), out svar))         // ! == false
            {
                Console.WriteLine("Icke giltigt bordsnummer, vg försök igen");
            }

            return svar;
        }
    }
}
