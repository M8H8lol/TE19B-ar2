using System;

namespace MorseTolk
{
    class Program
    {
        static void Main(string[] args)
        {
            // Berätta om programmet
            Console.WriteLine("Det här programmet översätter din text i morse. Vad vill du översätta? ");

            // Be om ett meddelande
            Console.WriteLine("Ange ett meddelande: ");
            string meddelande = Console.ReadLine().ToUpper();

            // Skapa en samling för alfabetet
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVXYZÅÄÖ ";

            // Skapa en samling för morsekode (array)
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", "/" };

            // Loopa igenom meddelandet
            string MorseMeddelande = "";
            for (int i = 0; i < meddelande.Length; i++)
            {
                // Skriv ut varje tecken 
                string bokstav = meddelande[i].ToString();
                Console.WriteLine($"{bokstav}");

                // Hitta bokstavens platsi alfabetet
                int index = alfabetet.IndexOf(bokstav);

                // Vart fanns bokstaven?
                Console.WriteLine($"{bokstav} finns på position {index}");

                // Skriv ut morsekoden för bokstaven
                string morseBokstav = morse[index];
                Console.WriteLine($"{bokstav}'s morsekod är {morseBokstav}");

                // Samla in hela meddelandet i morsekod
                MorseMeddelande += morseBokstav;

            }

            // Skriv ut hela meddelandet i morsekod
            Console.WriteLine(MorseMeddelande);
        }
    }
}
