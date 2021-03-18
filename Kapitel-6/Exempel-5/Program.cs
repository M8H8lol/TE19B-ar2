using System;

namespace Exempel_5
{
    class Program
    {
        // EN klassvariabel
        static string respons = "Du skrev inte ett heltal, vg försök igen";
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett heltal");
            int tal = ReadInt();
        }

        /// <summary>
        /// Metoden ör säkert sätt att läsa in heltal
        /// </summary>
        /// <returns>Heltal</returns>
        static int ReadInt()
        {
            int svar = 0;
            while (!int.TryParse(Console.ReadLine(), out svar))     // ! == false
            {
                Console.WriteLine(respons);
            }
            return svar;
        }
    }
}
