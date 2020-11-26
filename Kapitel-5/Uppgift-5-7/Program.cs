using System;

namespace Uppgift_5_7
{
    class Program
    {
        static void Main(string[] args)
        {

            // Skapa en array med minst 5 heltal
            int[] tallista = { 164, 894, 179, 964, 783 };


            // Beräkna summan av alla heltal i arrayen med hjälp av en foreach-loop
            int summa = 0;
            foreach (var tal in tallista)
            {
                summa += tal;
            }

            // Skriv ut summan
            Console.WriteLine($"Summan är {summa}");
        }
    }
}
