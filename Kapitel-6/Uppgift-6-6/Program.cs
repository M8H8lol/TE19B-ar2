using System;

namespace Uppgift_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultat = Multiplicera(76.7, 4.5);
            Console.WriteLine(resultat);

            resultat = Dividera(100, 2.5);
            Console.WriteLine(resultat);
        }
        static double Multiplicera(double tal1, double tal2)
        {
            return tal1 * tal2;
        }
        static double Dividera(double tal1, double tal2)
        {
            return tal1 / tal2;
        }
    }
}
