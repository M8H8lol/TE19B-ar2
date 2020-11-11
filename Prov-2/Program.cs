using System;

namespace Prov_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string bruttolön = 0;

            Console.WriteLine("Ange din bruttolön i kronor");
            Console.WriteLine("Vg mata in ett heltal!");

            bruttolön = TryParse(Console.ReadLine());
            Console.WriteLine($"Du har alltså {bruttolön} i bruttolön!");
        }
    }
}
