using System;

namespace Exempel_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn = "Amir";
            Console.WriteLine("Mitt namn är " + namn);

            // Med hjälp av variabelsubtitution
            Console.WriteLine($"Mitt namn är {namn}");

            string svar = $"Mitt förnamn är {namn}";
            Console.WriteLine(svar);
            System.Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
