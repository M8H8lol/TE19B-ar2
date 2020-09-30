using System;

namespace Uppgift_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in poäng
            Console.Write("Hur många poäng fick du på provet");
            int poäng = int.Parse(Console.ReadLine());

            // Skriv ut betyg
            if (poäng >= 55)
            {
                Console.WriteLine("Du fick betyget A");
            }
            else if (poäng >= 46)
            {
                Console.WriteLine("Du fick betyget B");
            }
            else if (poäng >= 35)
            {
                Console.WriteLine("Du fick betyget C");
            }
            else if (poäng >= 27)
            {
                Console.WriteLine("Du fick betyget D");
            }
            else if (poäng >= 18)
            {
                Console.WriteLine("Du fick betyget E");
            }
            else
            {
                Console.WriteLine("DU FICK F LOL");
            }


        }
    }
}

