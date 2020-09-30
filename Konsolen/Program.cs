using System;

namespace Konsolen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ändrar bakrundsfärg på terminalen
            Console.BackgroundColor = ConsoleColor.DarkRed;

            //Ändra textgärg i terminalen
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Hello World!");
        }
    }
}
