using System;

namespace Övningsprov_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            while (true)
            {

                int number = rng.Next(1, 10);
                int number1 = rng.Next(1, 10);

                Console.WriteLine($"x * {number1} = {number * number1}");

                string svar = Console.ReadLine();

                while (svar != number.ToString())
                {
                    Console.WriteLine("Fel svar, försök igen!");
                    svar = Console.ReadLine();
                }
                Console.WriteLine("Du hade rätt!");

                
            }
        }
    }
}

/*
// Deklarera variabler
int poäng = 0;
int gissning = 0;
string gissningText = "";
bool lyckades = false;

// Ställa frågan 
Console.Writeline("Vad är x i formeln x * 6 = 42?");

// Läs in användarens svar tils det funkar
while(lyckades == false)
{
    // Läs in det användaren skriver
    gissningText = Console.ReadLine();

    // Är det ett tal eller inte?
    // Blir true eller false
    lyckades = int.TryParse(gissning, out gissning);

    // Varnar användaren om hen inte matar in ett tal
    Console.Writeline("Fel! Var god mata in ett tal!");

}

// Kolla om gissnigen är korrekt eller inte
if (gissning == "7")
{
    Console.Writeline("Rätt svar, bra jobbat!");    
}
else 
{
    Console.Writeline("Fel svar!);
}

*/