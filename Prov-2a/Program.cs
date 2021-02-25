using System;
using System.IO;

namespace Prov_2a
{
    class Program
    {
        static void Main(string[] args)
        {

            int antalFilmer = 50;
            string filmer = "movies.tsv";

            string[] filmInformation;

            Console.WriteLine("Detta är en sökmotor för filmer");

            if (File.Exists(filmer))
            {
                filmInformation = File.ReadAllLines(filmer);
                Console.WriteLine("Filmerna lästes in från filen");
            }

            string menyVal = "";
            while (menyVal != "3")
            {
                Console.WriteLine("Program för att söka filmer");
                Console.WriteLine("1. Visa alla filmer");
                Console.WriteLine("2. Sök år");
                Console.WriteLine("3. Avsluta");
                Console.Write("Välj ett alternativ:");
                menyVal = Console.ReadLine();


                string filmNamn = "";
                int årTal = 0;
                string[] delar;
                switch (menyVal)
                {
                    case "1":
                        for (int i = 0; i < antalFilmer; i++)
                        {
                            delar = filmsInformation[i].Split(',');
                            filmNamn = delar[1];
                            årTal = delar[3];
                        }
                        break;


                    case "2":

                        break;

                    case "3":
                        break;


                    default:
                        break;
                }
            }
        }
    }
}
