using System;

namespace Pseudokod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv välkomstmeddelande
            Console.WriteLine("Vällkommen till 21:an!");

            // Sätt menyVal till 0
            string menyVal = "0";

            // while (menyval != "4")
            while (menyVal != "4")
            {
                // Skriv ut meny
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta programmet");
                menyVal = Console.ReadLine();
            }

            // Tom rad inann användarens val körs 
            Console.WriteLine();

            // switch menyVal
            switch (menyVal)
            {
                // case 1: Spela en omgång av 21:an
                case "1":
                    break;

                // case 2: Visa senaste vinnaren
                case "2":
                    break;

                // Visa spelets regler
                case "3":
                    break;

                // Gör ingenting (programmet avslutas)
                case "4":
                    break;

                default:
                    Console.WriteLine("Du valde inte ett giltigt alternativ");
                    break;
            }


        }
    }
}
