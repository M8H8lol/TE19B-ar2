using System;

namespace Uppgift_6_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = Addera(15, 19, 27);
            Console.WriteLine(summa);
        }
        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }
    }
}
