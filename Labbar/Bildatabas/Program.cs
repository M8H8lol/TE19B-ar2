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
            // Medans den parsade stringen inte är en double så får man ett felmeddelande
            double tankensInnehåll = FrågaEfterDouble("Hur stor är bilens tank: ", "Ogiltigt svar, var vänlig försök igen. ");

            // Frågar efter bilens förbrukning
            double förbrukning = FrågaEfterDouble("Ange förbrukning (l/mil): ", "Ogiltigt svar, var vänlig försök igen");

            // Skapar en whileoop för att fråga om yttligare resor
            int vilkenResa = 0;
            while (true)
            {
                vilkenResa++;

                // Numrerar resorna
                Console.WriteLine($"\nResa {vilkenResa}");

                // Frågar efter hastigheten under resan
                double hastighet = FrågaEfterDouble("Ange hastighet (km/h): ", "Ogiltigt svar, hastigheten måste vara under 200 km/h");

                // Frågar hur länge bilen körde
                double tid = FrågaEfterDouble("Ange tid (min): ", "Ogiltig tid, får inte vara mer än 2000 minuter");

                // @todo
                // Vad händer om bensinen inte räcker?
                // Skriv ut den faktiska resan och avbryt. 

                // Kallar in metoden för att räkan ut det totala avståndet
                double totalAvstånd = RäknaUtKörsträcka(hastighet, tid);
                Console.WriteLine($"Ditt avstånd är {totalAvstånd}");

                // Kallar på metoden för att räkna ut den totala förbrukningen
                double restITank = tankensInnehåll;
                double totalFörbrukning = FörbrukningILiter(förbrukning, totalAvstånd);
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
        static double RäknaUtKörsträcka(double hastighetKm, double tidMin)
        {
            return hastighetKm * tidMin / 60;
        }

        /// <summary>
        /// Räknar ut den totala förbrukningen under resan
        /// </summary>
        /// <param name="förbrukning"></param>
        /// <param name="sträcka"></param>
        /// <returns>totalFörbrukning</returns>
        static double FörbrukningILiter(double förbrukningPerMil, double sträckaKm)
        {
            return förbrukningPerMil * sträckaKm / 10;
        }

        /// <summary>
        /// Räknar ut den mängd bensin som finns kvar i tanken
        /// </summary>
        /// <param name="restITank"></param>
        /// <param name="förbrukning"></param>
        /// <returns>kvarITanken</returns>
        static double RäknaUtKvarITanken(double restITankLiter, double förbrukningPerMil)
        {
            return restITankLiter - förbrukningPerMil;
        }
        static double FrågaEfterDouble(string fråga, string errorMeddelande)
        {
            Console.Write(fråga);
            double svar = 0;
            while (!double.TryParse(Console.ReadLine().Replace('.', ','), out svar))
            {
                Console.WriteLine(errorMeddelande);
            }
            return svar;
        }
    }
}
