using System;

namespace Appdevhb25.NoahHois.Aufgabe3
{
    public class SummeUeberBereich
    {
        public static void Aufgabe3()
        {
            int intervallstart = 8;
            int intervallende = 10;
            int summe = 0;
            for (int i = intervallstart; i <= intervallende; i++)
            {
                summe = summe + i;
            }
            Console.WriteLine(summe);
        }   
    }
}