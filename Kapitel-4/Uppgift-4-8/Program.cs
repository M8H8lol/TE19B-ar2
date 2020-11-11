using System;

namespace Uppgift_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren om ett tal
            Console.Write("Ange ett tal: ");
            string svar = Console.ReadLine();

            // Testa läsa av tecken i en string
            Console.WriteLine($"Första tecknet är svar [0] och blir {svar[0]}");
            Console.WriteLine($"Andra tecknet är svar [1] och blir {svar[1]}");
            Console.WriteLine($"Tredje tecknet är svar [2] och blir {svar[2]}");
            Console.WriteLine($"Fjärde tecknet är svar [3] och blir {svar[3]}");


            // RÄkna fram längden på svaret
            int längd = svar.Length;
            Console.WriteLine($"Längden på talet är {längd}");

            // Loopa igenom talet
            // Från första tecken till sista tecken

            int antal = 0;
            for (int i = 0; i < längd; i++) // Hissen
            {
                Console.WriteLine($"index = {i}, tecknet: {svar[i]}");

                // För varje tecken: Är det 3 eller 7?
                if (svar[i] == '3' || svar[i] == '7')
                {
                    antal++;
                }
            }
            Console.WriteLine($"Antal = {antal}");

            // Svaret: Finns en 3:a eller en 7:a i talet?
            if (antal > 0)
            {
                Console.WriteLine("Hurra! Det finns en 3:a eller en 7:a");
            }
            else
            {
                Console.WriteLine("Talet har ingen 3:a eller 7:a");
            }
        }
    }
}
