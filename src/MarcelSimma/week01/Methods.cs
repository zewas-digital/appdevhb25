using System;

namespace Appdevhb25.MarcelSimma.Aufgabe06
{
    public class Methods
    {

        public static void Start()
        {
            Console.WriteLine("Methoden");

            // camelCase für Variablen
            //int meineTolleZahl = 5;

        }

        /*

        // public - Zugriffsmodifizierer
        // static - Methode an Klasse oder Objekte gebunden
        // void - keine Rückgabe erwartet
        // int - Zahl vom Typ Integer wird zurückgegeben
        // Start - name der Methode; Konvetion: PascalCase
        // () - Parameterübergabe
        
        */

        // Aufgabe: Methode, die "Hallo <Vorname>" ausgibt. Vorname ist ein Übergabeparameter
        // void: kein Rückgabewert
        public static void PrintVorname(string vorname)
        {
            Console.WriteLine($"Hallo, {vorname}");
            // Console.WriteLine("Hallo, " + vorname);
        }

        // PrintRectangle
        public static void PrintRectangle(int zeilen, int spalten)
        {
            for (int y = 0; y < zeilen; y++)
            {
                for (int x = 0; x < spalten; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Aufgabe Add(): Summe von zwei Parametern berechnen und zurückgeben

        public static int Add(int a, int b)
        {
            int summe = a + b;
            return summe;
        }


    }
}