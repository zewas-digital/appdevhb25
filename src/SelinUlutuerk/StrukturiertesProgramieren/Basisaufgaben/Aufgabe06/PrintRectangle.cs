using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe06
{
    class PrintRectangle
    {
        public static void Start()
        {
            int zeilen = 5, spalten = 3;

            for (int y = 0; y < zeilen; y++)
            {
                for (int x = 0; x < spalten; x++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

            /*
            if ... else if ... else
            Verwendung für bedingtes Ausführen

            if (Bedingungen: a == b)
            {


                int c = 0;
            }
            else if (Alternative Bedingungen) {
            
            }
            else
            {
                Console.WriteLine(c) // funktioniert nicht, da c nur im if-Block definiert ist.
            }

            */
        }
    }
}    