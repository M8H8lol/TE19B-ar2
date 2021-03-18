using System;

namespace Uppgift_6_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int svar = Störst(50, 50);
            Console.WriteLine(svar);
        }
        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }
        }
    }
}
