using System;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "";

            Console.WriteLine("Hej! Vad heter du?");

            // Skapar en variabel för spelarens namn
            string namn = Console.ReadLine();

            Console.WriteLine("Hej " + namn + "! Är du redo för en frågesport? ");

            val = Console.ReadLine();

            if (val == "Ja" || val == "ja")
            {
                Console.WriteLine("Då kör vi igång!");
                Console.WriteLine("Hur många länder finns det i Europa? ");
                Console.WriteLine("1. Det finns 48 länder i Europa");
                Console.WriteLine("2. Det finns 49 länder i Europa");
                Console.WriteLine("3. Det finns 50 länder i Europa");
            }

            if (val == "1")
            {
                Console.WriteLine("Det var tyvärr fel!");
            }

        }
    }
}
