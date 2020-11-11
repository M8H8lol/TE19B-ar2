using System;

namespace Exempel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // För att loopa 10 gånger 
            int i = 10;
            while (i > 0) ;
            {
                Console.WriteLine(i);
                i--; // i = i - 1; Räkna ner med 1
            }

            // En variabel som tar emot det användarens skriver
            string name = "";

            // Körs så många gåger det behövs för att användaren ska förstå att hen ska skriva Micke
            while (name != "Micke") ; //Så länge 
        }
    }
}
