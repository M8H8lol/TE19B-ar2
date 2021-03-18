using System;

namespace Uppgift_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta är ett program som kan utföra beräkningar");
            string användarensVal = "";
            while (användarensVal != "4")
            {
                SkrivMenyn();
                användarensVal = Console.ReadLine();
                // Console.WriteLine(); ??

                switch (användarensVal)
                {
                    case "1":
                        Addera();
                        break;

                    case "2":
                        Subtrahera();
                        break;

                    case "3":
                        Multiplicera();
                        break;

                    case "4":
                        // Programmet avslutas
                        break;
                    default:
                        Console.WriteLine("Ditt svar är ogiltigt");
                }
                // Console.Writeline(); ??
            }
        }
        static void SkrivMeny()
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Addera två tal");
            Console.WriteLine("2. Subtrahera två tal");
            Console.WriteLine("3. Multiplicera två tal");
            Console.WriteLine("4. Avsluta programmet");
        }

        static void Addera()
        {
            Console.WriteLine("Skriv in två tal");
        }

        static void Subtrahera()
        {
            Console.WriteLine("Skriv in två tal");
        }

        static void Multiplicera()
        {
            Console.WriteLine("Skriv in två tal");
        }
    }
}
