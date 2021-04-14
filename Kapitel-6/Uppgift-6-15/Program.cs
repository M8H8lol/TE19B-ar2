using System;

namespace Uppgift_6_15
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivBakLänges("HEJSAN");

            SkrivBakLänges(765);

            SkrivBakLänges(56.7);
        }

        static void SkrivBakLänges(string meddelande)
        {
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.Write(meddelande[i]);
            }
        }
        static void SkrivBakLänges(int helTal)
        {
            SkrivBakLänges(helTal.ToString());
        }
        static void SkrivBakLänges(double decimalTal)
        {
            SkrivBakLänges(decimalTal.ToString());
        }
    }
}
