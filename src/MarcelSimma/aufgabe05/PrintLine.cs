using System;

namespace Appdevhb25.MarcelSimma.Aufgabe05
{
    public class PrintLine
    {
        public static void Start()
        {
            int anzahlZeichen = 10;

            // klassische Anwendung: Listen, Arrays
            // Anwendung, wenn Anzahl der Iterationen bekannt ist.

            for (int i = 0; i < anzahlZeichen; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            // klassiche Anwendung: Validierung von Inputs
            // Anwendung, wenn die Anzahl der Iterationen unbekannt ist.


            int ausgegebeneZeichen = 0;
            while (ausgegebeneZeichen < anzahlZeichen)
            {
                Console.Write("*");
                ausgegebeneZeichen++;
            }

            // klassische Anwendung: Validierung eines Inputs soll mindestens einmal ausgeführt werden.
            // Anwendung, wenn die Anzahl der Iterationen unbekannt ist.

            do
            {
                Console.Write("*");
                ausgegebeneZeichen++;
            } while (ausgegebeneZeichen < anzahlZeichen);

        }
    }
}