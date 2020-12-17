using System;

namespace Spel
{
    class Program
    {
        static void Main(string[] args)
        {
            // För att skriva ut Entities
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Slumpa fram in en tomte i labyrinten
            Random slumpMotor = new Random();

            // Skapa en labyrint
            int[,] labyrint = {
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},  // 0
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},  // 1
                {1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1},  // 2
                {1, 0, 1, 1, 0, 0, 1, 0, 1, 0, 1},  // 3
                {1, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1},  // 4
                {1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},  // 5
                {1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1},  // 6
                {1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1},  // 7
                {1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1},  // 8
                {1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1}   // 9
            };

            // Var är spelaren
            int spelarePosX = 1;    // Ingången till labyrinten
            int spelarePosY = 9;

            // Placera ut tomtarna
            int antalTomtar = 3;
            while (antalTomtar != 0)
            {
                // Slumpa fram koordinater
                int x = slumpMotor.Next(0, 11);  // 0-10
                int y = slumpMotor.Next(0, 10);  // 0-9

                // Hamnar figuren i en gång?
                if (labyrint[y, x] == 0)
                {
                    labyrint[y, x] = 2;
                    antalTomtar--;
                }
            }



            // Spelloopen
            while (true)
            {
                Console.Clear();


                // Infoga spelaren
                labyrint[spelarePosY, spelarePosX] = 3;

                // Skriva ut labyrinten
                // Loopa igenom rad för rad, dvs i y-led
                for (int y = 0; y < 10; y++)
                {
                    // Loopa igenom kolumnvis, dvs x-led
                    for (int x = 0; x < 11; x++)
                    {
                        switch (labyrint[y, x])
                        {
                            case 1: // En vägg
                                Console.Write('\u2B1C');
                                break;

                            case 2: // En tomte
                                Console.Write("🎅");
                                break;

                            case 3: // En spelare
                                Console.Write("😀");
                                break;

                            default: // En gång
                                Console.Write('\u2B1B');
                                break;
                        }
                    }
                    Console.WriteLine();
                }
                // Fråga användaren vart spelaren skall gå
                Console.Write("Vart vill du gå? (W/A/S/D)");
                // Läs in, omvandla till stora bokstäver, och ta första tecknet
                string riktning = Console.ReadLine().ToUpper().Substring(0, 1);

                // Radera gamla positionen på spelaren
                labyrint[spelarePosY, spelarePosX] = 0;

                // Hantera svaret: FLytta på spelaren
                switch (riktning)
                {
                    case "W":
                        spelarePosY--;
                        break;
                    case "A":
                        spelarePosX--;
                        break;
                    case "S":
                        spelarePosY++;
                        break;
                    case "D":
                        spelarePosX++;
                        break;
                    default:
                        Console.WriteLine("Förstod inte vad du menade. Vg försök igen");
                        break;
                }
            }
        }
    }
}
