using System.Reflection.Metadata;

namespace Appdevhb25.MarcelSimma
{
    public class StringFormat
    {
        public static void Start()
        {
            /*
            Formatierung von Strings
            ========================
            */

            string vorname = "Marcel";
            string nachname = "Simma";
            int alter = 24;

            // 1. Möglichkeit: Verkettung von Strings und Variablen
            string message1 = "Hallo " + vorname + " " + nachname + ". Du bist " + alter + " Jahre alt.";
            Console.WriteLine(message1);

            // 2. Möglichkeit: Platzhalter {0}, {1}, ... werden durch die Argumente der Format-Methode ersetzt. 
            // {0} wird zu vorname, {1} zu nachname, {2} zu alter, usw.
            string message2 = string.Format("Hallo {0} {1}. Du bist {2} Jahre alt.", vorname, nachname, alter);
            Console.WriteLine(message2);

            // 2. Möglichkeit: Interpolierte Strings
            string message3 = $"Hallo {vorname} {nachname}. Du bist {alter} Jahre alt.";
            Console.WriteLine(message3);

            // 3. Möglichkeit: Kombinierte Verwendung von $ und @
            string message4 = $@"
            Hallo {vorname} {nachname}. 
            Du bist {alter} Jahre alt.";

            // Leerzeichen erzeugen
            Console.WriteLine(new string('-', 40));

            // Gleitkommazahlen formatieren
            string decimalNumberString = string.Format("{0:F2}", 12345.67890);
            Console.WriteLine(decimalNumberString);

            // Als Währung formatieren
            System.String currencyString = System.String.Format("{0:C3}", 12345.67890);
            Console.WriteLine(currencyString);                    // 3 ist die Anzahl der Nachkommastellen

            // Als Ganzzahl formatieren
            System.String integerString = System.String.Format("{0:D}", 12345);
            Console.WriteLine(integerString);

            // Als Zehnerpotenz formatieren
            System.String exponentString = System.String.Format("{0:E2}", 12345.67890);
            Console.WriteLine(exponentString);

            // rechtsbündig mit fester Breite
            System.String rightAlignedString = System.String.Format("{0,10}", 12345);
            Console.WriteLine(rightAlignedString + ".");

            // linksbündig mit fester Breite
            System.String leftAlignedString = System.String.Format("{0,-10}", 12345);
            Console.WriteLine(leftAlignedString + ".");

            double[] numbers = { 1.234, 12.345, 123.456, 1234.567, 12345.678, 123456.789 };
            foreach (double number in numbers)
            {
                // verschiedene Formatierungen für Zahlen
                Console.WriteLine(String.Format("Number: {0,15:F2} | {0,15:N2} | {0,15:E2} | {0,15:C2}", number));
            }   
        }
    }
}