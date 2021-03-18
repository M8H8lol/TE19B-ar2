using System;

namespace Uppgift_6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int antalTecken = AntalISträng('m', "margarita");
        }
        static int AntalISträng(char tecken, string text)
        {
            int antal = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == tecken)
                {
                    antal++;
                }
            }
            return antal;
        }
    }
}
