using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string lön = Console.ReadLine();
            int lönMindreÄn10000 = lön / 0.08;


            Console.WriteLine("Hur mycket bruttolön får du? ");
            lön = Console.ReadLine();
            Console.WriteLine($"Du får alltså {lön} kr i lön");

            if (lön >= 100000)
            {
                Console.WriteLine($"Då är din marginalskatt {lönMindreÄn10000}");
            }
        }
    }
}
