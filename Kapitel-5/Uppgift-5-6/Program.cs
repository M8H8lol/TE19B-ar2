using System;

namespace Uppgift_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] städer = new string[5];



            for (int i = 0; i < städer.Length; i++)
            {
                Console.WriteLine("Ange 1 stad");
                städer[i] = Console.ReadLine();
            }

            Console.WriteLine("");
            Console.WriteLine("Du skrev städerna: ");

            foreach (var stad in städer)
            {
                Console.WriteLine(stad);
            }

            // Console.WriteLine($"Städerna är {städer}");
        }
    }
}
