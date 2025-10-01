using System;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe03
{
    //Erstelle ein Programm, das die Summe aller Zahlen in einem Intervall berechnet und ausgibt.
    public class SummeUeberBereich
    {
        public static void Start()
        {
            int intervallStart = 8;
            int internallEnde = 10;
            int sum = 0;
            for (int i = intervallStart; i <= internallEnde; i++)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }
        }
    }
    
}