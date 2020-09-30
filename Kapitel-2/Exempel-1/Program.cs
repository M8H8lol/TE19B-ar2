using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera en variabel för namnet
            string namn = "";
            string hobby = "";
            string meddelande = "";

            // Läs in namnet
            Console.Write("Vad heter du? ");
            namn = Console.ReadLine();

            //Läs in hobby
            Console.Write("Vad är din hobby? ");
            hobby = Console.ReadLine();

            // Sätter samman ett meddelande
            meddelande = "Trevligt att träffas " + namn + ", jag gillar också att " + hobby;

            //Skriver ut meddelandet
            Console.WriteLine(meddelande);


        }
    }
}