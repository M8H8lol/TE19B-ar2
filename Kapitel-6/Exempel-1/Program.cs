using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi skrivver texten vertikalt");

            // Den första texten
            SkrivVertikalt("Metoder!!!");

            // Den första texten
            SkrivVertikalt("Metoer är kul");

            // Den första texten
            SkrivVertikalt("Mycket användbart i min programmering");
        }

        // En metod för att skriva text vertikalt
        static void SkrivVertikalt(string text1)
        {
            for (int i = 0; i < text1.Length; i++)
            {
                Console.WriteLine(text1[i]);
            }
        }
    }
}
