using System;

namespace SlumpBetyg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Slumpa fram ett tal 0-1
            // Där 0 = F, 1 = E, 2 = D osv...
            // Skapa en slumpgenerator
            Random tärning = new Random();

            // kasta tärningen
            int slumptal = tärning.Next(0, 8);
            Console.WriteLine($"Slumptalet = {slumptal}");
            /* 
                        // Skriv ut slumpade betyg
                        // Alternativ 1
                        if (slumptal = 0)
                            Console.WriteLine("Du fick betyg F!");
                        if (slumptal = 1)
                            Console.WriteLine("Du fick betyg E!");
                        if (slumptal = 2)
                            Console.WriteLine("Du fick betyg D!");
                        if (slumptal = 3)
                            Console.WriteLine("Du fick betyg C!");
                        if (slumptal = 4)
                            Console.WriteLine("Du fick betyg B!");
                        if (slumptal = 5)
                            Console.WriteLine("Du fick betyg A!"); */


            /*        // Alternativ 2:
                   switch (slumptal)
                   {
                       case 1:
                           Console.WriteLine("Du fick betyg E!");
                       case 2:
                           Console.WriteLine("Du fick betyg D!");
                       case 3:
                           Console.WriteLine("Du fick betyg C!");
                       case 4:
                           Console.WriteLine("Du fick betyg B!");
                       case 5:
                           Console.WriteLine("Du fick betyg A!");


                       default:
                       Console.WriteLine("Du fick betyg F!");
                       break;
                   } */

            // Alternativ 3:
            string[] betyg = { "F", "E", "E", "E", "D", "C", "B", "A" };
            Console.WriteLine($"Du fick {betyg[slumptal]} i slutbetyg");
        }
    }
}
