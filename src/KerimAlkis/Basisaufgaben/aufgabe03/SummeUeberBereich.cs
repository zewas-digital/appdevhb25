using System;

namespace Appdevhb25.KerimAlkis.Aufgabe03
{
    public class SummeUeberBereich
    {
        public static void Start()
        {
            System.Console.WriteLine("\nSummeUeberBereich");
            int start = 8;
            int ende = 10;
            int summe = 0;
            for (int i = start; i <= ende; i++)
            {
                summe += i;
            }
            System.Console.WriteLine("Summe = " + summe);
        }
    }
}