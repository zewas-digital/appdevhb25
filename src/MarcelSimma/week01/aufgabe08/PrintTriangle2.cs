/*
Aufgabe 8: PrintTriangle2
Erstelle eine Programm, welches ein rechtwinkliges Dreieck mit variabler Größe ausgibt.
 
xxxxx
 xxxx
  xxx
   xx
    x

*/

using System;

namespace Appdevhb25.MarcelSimma.Aufgabe08
{
    public class PrintTriangle2
    {
        public static void Start(int size)
        {

            /*
            1. Aufgabe lesen
            2. verstehen und offene Fragen klären
            3. Kann ich Teilprobleme/-aufgaben bilden?
               --> jedes Dreieck ist ein Teilproblem und wird individuell betrachtet
            4. Variablen und Ressourcen bestimmen
            4.1. Was brauche ich?
            4.2. Sinnvolle Bennennung; mindestens 3 Zeichen außer bei Zählvariablen
            4.3. Überlegen wie ich Variable verwende, (un)gültige Werte, usw.
            4.4. Welche Schleifen und Abfragen (if else)?
                 --> mindestens 2 Schleifen und maximal 3
                 --> mindestens 0 und maximal 1 Abfrage

                size: größe des Dreiecks; der Wert bleibt bis zum Ende der Methode gleich
                y: Zählvariable für die Zeilen
                x: Zählvariable für die Spalten

            */

            // Variante 1: 2 Schleifen und 1 Abfrage

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    /*
                    
                    if else für Entscheidung, ob " " oder "*"

                    xxxxx   y = 0, x = 0..4
                    .xxxx   y = 1, x = 0..4
                    ..xxx   y = 2, x = 0..4
                    ...xx   y = 3, x = 0..4
                    ....x   y = 4, x = 0..4

                    --> Pareto Regel: 80 % der Zeit zum Nachdenken, 20 % programmieren

                    */
                    if (x < y)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("x");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Variante 2: 3 Schleifen und 0 Abfragen

            for (int y = 0; y < size; y++)
            {

                for (int x = 0; x < y; x++)
                {
                    Console.Write(" ");
                }

                for (int x = size; x > y; x--)
                {
                    /*
                    xxxxx   y = 0, x = 5..1
                    .xxxx   y = 1, x = 5..1
                    ..xxx   y = 2, x = 5..1
                    ...xx   y = 3, x = 5..1
                    ....x   y = 4, x = 5..1
                    */

                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Teilaufgabe 3

            /*
            size = 5

                    y   x
            ....x   0   5..1
            ...xx   1   5..1
            ..xxx   2
            .xxxx   3
            xxxxx   4

            --> Die Anzahl der "x" ist immer um eines größer als y.

            */

            for (int y = 0; y < size; y++)
            {
                for (int x = size; x > 0; x--)
                {
                    if (x - 1 > y)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("x");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}