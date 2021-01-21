using System;

namespace Filhantering3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Skapa/skriv över en fil");
            Console.WriteLine("2. Läs in innehållet från en fil");
            string val = Console.ReadLine();

            Console.WriteLine("Skriv filens namn");
            string filnamn = Console.ReadLine();

            switch (val)
            {
                case "1":
                    Console.WriteLine("Skriv en rad som du vill skriva in i filen");
                    string rad = Console.ReadLine();
                    File.WriteAllText(filnamn, rad);
                    Console.ReadLine("Texten är sparad i filem");
                    break;

                case "2":
                    if (File.Exists(filnamn))
                    {
                        string filinnehåll = File.ReadAllText(filnamn)
                        Console.WriteLine("Filens innehåll: ");
                        Console.WriteLine(filinnehåll);
                    }
                    else
                    {
                        Console.WriteLine("Filen finns inte för i helvete, skärp dig nu!");
                    }
                    break;


                default:
                    break;
            }

            Console.WriteLine("Tryck på en tangent för att avsluta programmet");
            Console.ReadKey();
        }
    }
}
