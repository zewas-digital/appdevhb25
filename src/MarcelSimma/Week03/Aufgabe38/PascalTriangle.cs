namespace Appdevhb25.MarcelSimma.Aufgabe38
{
    public class PascalTriangle
    {
        public static void Start()
        {
            /*
            Strukturierte Vorgehensweise:

              1. Aufgabe lesen und verstehen
              2. Offene Fragen klären (siehe Fotos im Teams)
              3. Implementierung, in Teilprobleme zerlegen und diese nacheinander lösen
              3.1. Größe des Pascaldreeicks abfragen
              3.2. Variablen definieren und Zweck bestimmen
              3.3. Ausgabe
              3.4. gesonderte Behandlung der 0. Zeile und 0. Spalte
              3.5. Implementierung der Berechnung
              3.6. Formatierung


            3.1. (ausgelassen)


            3.2.
            */

            // Initialisierung 2d Array für unser PascalDreieck.
            int[,] pascalTriangle = new int[10, 10];
            //  int[anzahlDerZeilen, anzahlDer Spalten]

            // klassisches 2d Array, weil die Spalten und Zeilenanzahl immer gleich ist. 
            // Ein klassisches 2d Array kann man sich wie ein Rechteck vorstellen.
            // Ein Jagged Array kann man sich wie ein Sägeblatt vorstellen.

            // Standardwert ist 0


            for (int y = 0; y < pascalTriangle.GetLength(0); y++) // Zeilen = y = 0. Dimension
            {
                for (int x = 0; x < pascalTriangle.GetLength(1); x++) // Spalten = x = 1. Dimension
                {
                    /*
                    3.4. Sonderbehandlung der 0. Zeile und 0. Spalte
                    */
                    if (y == 0) // 0. Zeile
                    {
                        pascalTriangle[y, x] = 1;
                    }
                    else if (x == 0)
                    { // 0. Spalte
                        pascalTriangle[y, x] = 1;
                    }
                    else
                    {
                        pascalTriangle[y, x] = pascalTriangle[y - 1, x] + pascalTriangle[y, x - 1];
                    }

                }

            }

            /*
            3.7. Berechnung der Zeichenanzahl der letzten Zahl im Pascal Dreieck

            Koordinaten dieser Zahl:
            y: GetLength(0) -> 6 - 1 = 5
            x: GetLength(1) -> 6 - 1 = 5

            */

            int tmp = pascalTriangle[pascalTriangle.GetLength(0) - 1, pascalTriangle.GetLength(1) - 1];
            int anzahlderZiffern = 2;

            while (tmp >= 10)
            {
                tmp = tmp / 10;
                anzahlderZiffern++;
            }

            /*
            3.3. Konsolenausgabe unseres Pascal Dreiecks
            */

            for (int y = 0; y < pascalTriangle.GetLength(0); y++) // Zeilen = y = 0. Dimension
            {
                for (int x = 0; x < pascalTriangle.GetLength(1); x++) // Spalten = x = 1. Dimension
                {
                    System.Console.Write("{0, " + anzahlderZiffern + "}", pascalTriangle[y, x]);
                }
                System.Console.WriteLine(); // Wenn die Zeile fertig geschrieben wurde, gibt es einen Zeilenumbruch
            }
        }
    }
}