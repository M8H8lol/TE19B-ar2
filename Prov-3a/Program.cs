using System;

namespace Prov_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadDouble();

            SkrivMeny();
        }
        static string SkrivMeny()
        {
            // Skriver ut menyn

            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Räkna ut ålder på Merkurius");
            Console.WriteLine("2. Räkna ut ålder på Venus");
            Console.WriteLine("3. Räkna ut ålder på Mars");
            Console.WriteLine("4. Räkna ut ålder på Jupiter");
            Console.WriteLine("5. Räkna ut ålder på Saturnus");
            Console.WriteLine("6. Räkna ut ålder på Uranus");
            Console.WriteLine("7. Räkna ut ålder på Neptunus");
            Console.WriteLine("8. Avsluta");

            // Läser in användarens val
            string menyVal = Console.ReadLine();
            return menyVal;


        }
        static double ReadDouble()
        {
            // Skriver ut meddelandet för att användaren ska skriva åldern
            Console.Write("Ange din ålder i jordår: ");
            string jordÅr = Console.ReadLine();

            // Konverterar jordÅr till en double för att det ska funka med metoden
            return double.Parse(jordÅr);

            string menyVal = "";
            double konverteratÅr = 0;
            switch (menyVal)
            {
                // Utför de matematiska beräkningara beroende på vilket menyVal användaren skriver in
                case "1":

                    konverteratÅr = jordÅr / 0.2408467;
                    Console.WriteLine($"På Merkurius är du {konverteratÅr}");
                    break;

                case "2":
                    konverteratÅr = jordÅr / 0.61519726;
                    Console.WriteLine($"På Venus är du {konverteratÅr}");
                    break;

                case "3":
                    konverteratÅr = jordÅr / 1.8808158;
                    Console.WriteLine($"På Mars är du {konverteratÅr}");
                    break;

                case "4":
                    konverteratÅr = jordÅr / 11.862615;
                    Console.WriteLine($"På Jupiter är du {konverteratÅr}");
                    break;

                case "5":
                    konverteratÅr = jordÅr / 29.447498;
                    Console.WriteLine($"På Saturnus är du {konverteratÅr}");
                    break;

                case "6":
                    konverteratÅr = jordÅr / 84.016846;
                    Console.WriteLine($"På Uranus är du {konverteratÅr}");
                    break;

                case "7":
                    konverteratÅr = jordÅr / 164.79132;
                    Console.WriteLine($"På Neptunus är du {konverteratÅr}");
                    break;

                case "8":
                    Console.WriteLine("Välkommen åter");
                    break;

                default:
                    break;
            }
        }
    }
}
