using System;

namespace Uppgift_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Skapa ett program som innehåller en array med minst 5 årtal, minst ett av årtalen ska finnas med två gånger. Användaren ska få skriva in ett årtal när programmet körs. Programmet ska skriva ut alla index som detta årtal finns på i arrayen. Om årtalet inte fanns på någon plats så ska programmet skriva "Årtalet kunde inte hittas"
            */

            // Skapa en array med minst 5 årtal
            int[] årtal = { 1914, 1918, 1939, 1945, 1962, 1789, 1783, 1200, 1500 };

            // Fråga användaren om ett årtal att söka
            Console.Write("Ange ett sökårtal: ");
            int gissning = int.Parse(Console.ReadLine());

            bool flagga = false;

            // Loopa igenom arrayen
            for (int i = 0; i < årtal.Length; i++)
            {
                // Skriv ut alla index om årtalet hittas i arrayen.
                if (årtal[i] == gissning)
                {
                    Console.WriteLine($"Hittat {gissning} på index {i}");
                    flagga = true;
                }
            }

            // Om årtalet inte fanns på någon plats så ska programmet skriva "Årtalet kunde inte hittas"
            if (!flagga) // samma som flagga == false
            {
                Console.WriteLine("Årtalet kunde inte hittas");
            }
        }
    }
}
