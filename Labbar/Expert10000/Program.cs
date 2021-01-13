using System;

namespace Expert10000
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ange hur många timmar
            Console.WriteLine("Hur många timmar vill du träna per dag? ");
            // Läs in användarens svar
            string svar = Console.ReadLine();
            double timmarPerDag = 0;

            // Kontrollera att användaren matar in ett tal
            // Isåfall översätt från string -> tal
            while (!double.TryParse(svar, out timmarPerDag) && timmarPerDag <= 0) ; // -> true / false
            {
                Console.WriteLine("Ogiltig input, vg försök igen! ");
                svar = Console.ReadLine();
            }

            // Räkna ut när man blir klar
            DateTime datumKlar = DateTime.Today.AddDays(10000 / timmarPerDag);
            TimeSpan hurLångTid = datumKlar - DateTime.Today;

            // Räkna ut antal år
            int antalÅr = hurLångTid.Days / 365;

            Console.WriteLine($"Du måste träna i {antal} år. mao är du klar år {datumKlar}.");
        }
    }
}
