using System;
using System.Dynamic;

namespace Appdevhb25.NoahHois.Aufgabe18
{
    public class InputValidieren
    {
        public static int GetIntegerFromConsole()
        {
            /*
                1. Methoden signatur und return
                2. Wert einlesen
                3. in Integer umwandeln
                4. while schleife
            */

            int inputAsInteger = 0;
            bool isInteger = false;

            while (!isInteger)
            {
                /*
                    1. Aufforderung zahl eizugeben
                    2. Zahl einlesen
                    3. Fehlermeldung
                    4. erneute Eingabe fordern wenn eine Fehlermeldung kommt
                    5. bedingung anpassen

                */
                Console.Write("Gib bitte eine Zahl ein: ");
                string inputFromConsole = Console.ReadLine();

                isInteger = int.TryParse(inputFromConsole, out inputAsInteger);


            }

            return inputAsInteger;
        }

        public static float GetFloatFromConsole()
        {
            float inputAsFloat = 0;
            bool isFloat = false;

            while (!isFloat)
            {
                Console.Write("Gib bitte eine Kommazahl ein: ");
                string inputFromConsole = Console.ReadLine();

                isFloat = float.TryParse(inputFromConsole, out inputAsFloat);
            }

            return inputAsFloat;
        }

        public static long GetLongFromConsole()
        {
            long inputAsLong = 0;
            bool isLong = false;

            while (!isLong)
            {
                Console.Write("Gib bitte eine lange Zahl ein: ");
                string inputFromConsole = Console.ReadLine();

                isLong = long.TryParse(inputFromConsole, out inputAsLong);
            }

            return inputAsLong;
        }
    }
}