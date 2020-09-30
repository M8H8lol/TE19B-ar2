using System;
/*
Ett program som skriver flera rader text.
*/
namespace Uppgift_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Denna skriver ut text
            /*  Console.WriteLine("Detta är ett program gjort i c#.");
             Console.WriteLine("Programmet skrivet ut text på flera rader.");
             Console.WriteLine("Detta är pgorammets sista utskrift"); */

            System.Console.WriteLine("Detta är ett \"program\" gjort i c#.\n" +
             "\\Programmet skrivet ut text på flera rader.\n" +
             "Detta\tär\tprogrammets\tsista\tutskrift\n");
        }
    }
}
