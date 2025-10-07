/*

Aufgabe 7: PrintTriangle
Erstelle eine Programm, welches ein rechtwinkliges Dreieck mit variabler Größe ausgibt.
 
xxxxx
 xxxx
  xxx
   xx
    x
 
 
 */

using System;

namespace Appdevhb25.MarcelSimma.Aufgabe07
{
    public class PrintTriangle
    {
        public static void Start(int size)
        {

            /*
            Inkrement: variable++; entspricht variable += 1 entspricht variable = variable + 1
            Decrement: variable--; entspricht variable -= 1 entspricht variable = variable - 1
            */
            for (int y = 0; y < size; y++)
            {
                /*
                Die Anzahl der Sterne pro Zeile nimmt mit jeder Zeile ab. 
                Wenn x immer mit 7 startet und y immer größer wird, 
                dann ergibt die Differenz die Anzahl der Sterne.
                */

                for (int x = size; x > y; x--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

