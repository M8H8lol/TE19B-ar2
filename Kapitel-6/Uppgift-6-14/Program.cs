using System;

namespace Uppgift_6_14
{
    class Program
    {
        static Random slump = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine(SlumpaPosition());
        }

        static int SlumpaRad()
        {
            return slump.Next(1, 9);
        }

        static char SlumpaKolumn()
        {
            string kolumn = "abcdefgh";
            int index = slump.Next(0, 8);
            return kolumn[index];
        }

        static string SlumpaPosition()
        {
            string position = SlumpaKolumn() + SlumpaRad().ToString();
            return position;
        }
    }
}
