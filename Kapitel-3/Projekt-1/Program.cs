using System;

namespace Projekt_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            string message = "";
            answer = Console.ReadLine();

            if (answer == "Yes")
            {
                message = "You said 'Yes'";
            }
            else if (answer == "No")
            {
                message = "You said 'No'";
            }
            else
            {
                message = "Invalid answer";
            }
            Console.WriteLine(message);
        }
    }
}
