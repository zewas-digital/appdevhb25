using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe05
{
    class PrintLine
    {
        public static void Start()
        {
            int Anzahl = 5;

            Console.WriteLine($"Anzahl der Zeichen: {Anzahl}");

            // klassche Anwendung: List, Arrays
            // Anwendung, wenn Anzahl der Iterationonen bekannt ist.
            
            for (int i = 0; i < Anzahl; i++)
            {
                Console.Write("x");
            }

            Console.WriteLine();

            // klassiche Anwendung: Validierung von Inputs (um sicher zu gehen das was richtiges kommt)
            // Anwendung, wenn die Anzhahl der Iterationen unbekannt ist.
            //Anzahl der Iterationnen: 0 bis n mal

            int ausgegebeneZeichen = 0;
            while (ausgegebeneZeichen < Anzahl)
            {
                Console.Write("x");
                ausgegebeneZeichen++;
            }

            Console.WriteLine();

            // klassiche Anwendung: Validierung soll mindestens einmal ausgeführt werden.
            // Andwendung, wenn die Anzahl Iterationen unbekannt ist.
            // Anzahl der Irationen: mindestens eine bis n mal

            do
            {
                Console.Write("x");
                ausgegebeneZeichen++;
            } while (ausgegebeneZeichen < Anzahl);
        }
    }
}