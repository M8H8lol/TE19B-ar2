using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera
            string val = "";

            // Presentera en meny som visas tills användaren säger stopp
            while (val != "3")
            {
                // Presentera en meny
                Console.WriteLine("Välj något av följande val: ");
                Console.WriteLine("1. Addera två tal ");
                Console.WriteLine("2. Multiplicera två tal ");
                Console.WriteLine("3. avsluta ");

                // Läs in användarens val
                val = Console.ReadLine();

                // Om val = 1
                if (val == "1")
                {
                    Console.WriteLine("Ange två tal efter varandra");
                    double tal1 = double.Parse(Console.ReadLine());
                    double tal2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{tal1} + {tal2} = " + (tal1 + tal2));
                }
                // Om val = 2
                if (val == "2")
                {
                    Console.WriteLine("Ange två tal efter varandra");
                    double tal1 = double.Parse(Console.ReadLine());
                    double tal2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{tal1} * {tal2} = " + (tal1 * tal2));
                }
                // Om val = 3
                if (val == "3")
                {
                    Console.WriteLine("Tack för idag");
                    break;
                }

                // Annars?
            }
        }
    }
}
