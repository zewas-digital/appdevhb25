// See https://aka.ms/new-console-template for more information
using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class SummeUeberBereich
    {
        public static void Start()
        {
            int start = 8;
            int ende = 10;
            int summe = 0;

            for (int i = start; i <= ende; i++)
            {
                summe += i;
            }
            Console.WriteLine("Intervallstart:" + start);
            Console.WriteLine("Intervallende:" + ende);
            Console.WriteLine("Summe über Intervall:" + summe);
        }
    }
}