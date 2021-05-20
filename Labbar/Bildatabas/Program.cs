using System;

namespace Bildatabas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introducerar programmet för använderen
            Console.WriteLine("Det här programmet ska räkna fram ett antal värdefulla data om en bil");

            // Frågar efter namn på användaren
            Console.Write("Ange ditt namn: ");
            string svarNamn = Console.ReadLine();

            // Frågar efter bilentankens volym
            Console.Write("Hur stor är bilens tank: ");
            string svarTankensInnehåll = Console.ReadLine();
            // double tankensInnehåll = double.Parse(svarTankensInnehåll);
            double tankensInnehåll = 0;
            while (!double.TryParse(svarTankensInnehåll, out tankensInnehåll))
            {
                Console.WriteLine("Ogiltigt svar, var vänlig försök igen. ");
                svarTankensInnehåll = Console.ReadLine();
            }

            // Frågar efter bilens förbrukning
            Console.Write("Ange förbrukning (l/mil): ");
            string svarFörbrukning = Console.ReadLine();
            // @todo 
            // Fixa så att programmet inte crashar om man matar in 0.8 (tryParse)

            // Skapar en whileoop för att fråga om yttligare resor
            int vilkenResa = 0;
            while (true)
            {
                vilkenResa++;

                // Numrerar resorna
                Console.WriteLine($"\nResa {vilkenResa}");

                // Frågar efter hastigheten under resan
                Console.Write("Ange hastighet (km/h): ");
                string svarHastighet = Console.ReadLine();
                int hastighet = 0;
                while (!int.TryParse(svarHastighet, out hastighet) || hastighet > 200)
                {
                    Console.WriteLine("Ogitligt svar, hastigheten måste vara under 200");
                    Console.Write("Ange hastighet (km/h): ");
                    svarHastighet = Console.ReadLine();
                }

                // Frågar hur länge bilen körde
                Console.Write("Ange tid (min): ");
                string svarTid = Console.ReadLine();
                int tid = 0;
                while (!int.TryParse(svarTid, out tid))
                {
                    Console.WriteLine("Ogiltig tid, får inte vara mer än 2000 minuter");
                }

                // @todo
                // Vad händer om bensinen inte räcker?
                // Skriv ut den faktiska resan och avbryt. 

                // Kallar in metoden för att räkan ut det totala avståndet
                int totalAvstånd = RäknaUtKörsträcka(hastighet, int.Parse(svarTid));
                Console.WriteLine($"Ditt avstånd är {totalAvstånd}");

                // Kallar på metoden för att räkna ut den totala förbrukningen
                double restITank = tankensInnehåll;
                double totalFörbrukning = RäknaUtTotalFörbrukning(double.Parse(svarFörbrukning), totalAvstånd);
                tankensInnehåll = RäknaUtKvarITanken(tankensInnehåll, totalFörbrukning);
                if (tankensInnehåll < 0)
                {
                    Console.WriteLine("Tanken är tom, du måste fylla på den innan din nästa resa");
                    tankensInnehåll = 0;
                    totalFörbrukning = restITank;
                }
                Console.WriteLine($"Bilens totala förbrukning är {totalFörbrukning}");

                // Kallar på metoden för att räkna ut hur mycket som finns kvar i tanken
                Console.WriteLine($"Bilen har kvar {tankensInnehåll} liter i tanken");

                // Frågar om användaren vill lägga till fler resor
                Console.Write("Vill du utföra beräkningar för en till resa (j/n)?");

                string svar = Console.ReadLine();

                // Om användaren inte vill fortsätta, så avslutar programmet
                if (svar == "n")
                {
                    Console.WriteLine($"Tack {svarNamn} för att du använde vårt program");
                    break;
                }
            }
        }

        /// <summary>
        /// Räknar ut hur långt bilen har kört i km
        /// </summary>
        /// <param name="hastighet"></param>
        /// <param name="tid"></param>
        /// <returns>avstånd</returns>
        static int RäknaUtKörsträcka(int hastighet, int tid)
        {
            int avstånd = hastighet * tid / 60;
            return avstånd;
        }

        /// <summary>
        /// Räknar ut den totala förbrukningen under resan
        /// </summary>
        /// <param name="förbrukning"></param>
        /// <param name="sträcka"></param>
        /// <returns>totalFörbrukning</returns>
        static double RäknaUtTotalFörbrukning(double förbrukning, int sträcka)
        {
            double totalFörbrukning = förbrukning * sträcka / 10;
            return totalFörbrukning;
        }

        /// <summary>
        /// Räknar ut den mängd bensin som finns kvar i tanken
        /// </summary>
        /// <param name="restITank"></param>
        /// <param name="förbrukning"></param>
        /// <returns>kvarITanken</returns>
        static double RäknaUtKvarITanken(double restITank, double förbrukning)
        {
            double kvarITanken = restITank - förbrukning;
            return kvarITanken;
        }
    }
}
