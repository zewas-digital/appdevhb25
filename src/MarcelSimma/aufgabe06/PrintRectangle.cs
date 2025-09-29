using System;

namespace Appdevhb25.MarcelSimma.Aufgabe06
{
    public class PrintRectangle
    {

        public static void Start()
        {

            // siehe Bild vom Flipchart im Teams

            int zeilen = 3, spalten = 5;

            for (int y = 0; y < zeilen; y++)
            {
                for (int x = 0; x < spalten; x++)
                {
                    Console.Write("*");
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