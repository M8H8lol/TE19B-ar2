using System;

namespace Uppgift_6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = Längst("Hej", "Hejsan");
            Console.WriteLine(svar);
        }
        static string Längst(string text1, string text2)
        {
            if (text1.Length > text2.Length)
            {
                return text1;
            }
            else
            {
                return text2;
            }
        }
    }
}
