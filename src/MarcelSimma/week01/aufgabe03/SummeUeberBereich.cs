using System;

namespace Appdevhb25.MarcelSimma.Aufgabe02
{
    public class SummeUeberBereich
    {

        public static void Start()
        {

            /*
            Allgemeine Vorgehensweise
            1. Aufgabe lesen und verstehen
            2. Welche Variablen brauche ich?
            3. Logik implementieren

            */

            int intervallstart = 8; // untere Intervallgrenze
            int intervallende = 10; // obere Intervallgrenze
                                    // alternativ: int intervallstart = 8, intervallende = 10;



            /*

Intervallgrenzen inkludiert: 8, 9, 10
Intervallgrenzen nicht inkludiert: 9

            */

            // speichert nach jedem Loop die Summe der bisher aufaddierten Zahlen
            int summe = 0;

            for (int i = intervallstart; i <= intervallende; i++)
            {
                summe = summe + i;
                // alternativ: summe += i;
            }
        }
    }
}