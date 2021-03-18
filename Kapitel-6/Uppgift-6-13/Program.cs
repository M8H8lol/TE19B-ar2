using System;

namespace Uppgift_6_13
{
    class Program
    {
        static Random slump = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine(SlumpaÅrtal());
            Console.WriteLine(SlumpaMånad());
        }

        static int SlumpaÅrtal()
        {
            return slump.Next(1900, 2000);
        }

        static int SlumpaMånad()
        {
            return slump.Next(1, 13);
        }
    }
}
