using System;

namespace Uppgift_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string meddelande = "Hello world";

            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
