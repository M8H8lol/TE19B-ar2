using System;

namespace Exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // En fallgrop när man räknar med heltal!
            Double delat = 7 / 2;
            Console.WriteLine("delat  = " + delat);

            Double delat2 = (double)7 / 2;
            Console.WriteLine("delat = " + delat2);

            Double delat3 = 7d / 2;
            Console.WriteLine("delat = " + delat3);

            float delat4 = 7f / 2;
            Console.WriteLine("delat = " + delat4); */

            // Läs in en epost-adress
            Console.WriteLine("Ange ett email: ");
            string email = Console.ReadLine();

            // Leta efter ett tecken i en text
            int position = email.IndexOf("@");
            Console.WriteLine("@ ligger på position = " + position);

            // Plocka namnet 
            string namn = email.Substring(0, position); // Från 0 -> position
            Console.WriteLine("namndelen = " + position);

            // Plocka domänet
            string domän = email.Substring(position + 1); // Från position + 1 -> slutet
            Console.WriteLine("Domändelen = " + domän);
        }
    }
}