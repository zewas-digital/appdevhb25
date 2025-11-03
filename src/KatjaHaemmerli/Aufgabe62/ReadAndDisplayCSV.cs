using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe62
{
    public  class ReadAndDisplayCSV
    {
        public static void ReadAndDisplay()
        {
            // Lies die CSV Datei ein und speichere diese in einem String. 
            // Zerlege den String zuerst in Zeilen und die Zeilen danach in Spalten. 
            // Speichere die Daten in ein zweidimensionales Array vom Typ String.

            // 1. Daten einlesen
            // 2. Daten in ein Array speichern
            // 3. Daten Ausgabe in Tabellenformat

            string csvDateiInut = @"C:\Users\haka\DigitalCampus\appdevhb25\src\KatjaHaemmerli\Aufgabe62\CSVDateiInput.csv";            

            using (StreamReader reader = new StreamReader(csvDateiInut))
            {                
                // gesamte Inhalt der Datei auf einmal einlesen
                string input = reader.ReadToEnd();
                
                // StringSplitOptions.Remove sorgt dafür, dass leere Zeilen nicht in die lines-Variable gespeichert werden
                string[] lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);

                // Die erste Zeile (Kopfzeile) an jedem ';' trennen,
                // um die Spaltenüberschriften als Array zu erhalten.
                // Das ';' ist wie die Trennlinie zwischen den Spalten.
                string[] ueberschrift = lines[0].Split(';');

                // Datensätze in Form von einzelnen Spalte aufteilen
                string[,] werte = new string[lines.Length - 1, ueberschrift.Length]; // werte speichert alle Daten aus der CSV-Datei, ohne die Kopfzeile.
                                                                                     // Zeilen: lines.Length - 1 = Anzahl der Datenzeilen (ohne Kopfzeile)
                                                                                     // Spalten: ueberschrift.Length = Anzahl der Spalten

                for (int i = 0; i < werte.GetLength(0); i++) // // Zeilen durchgehen
                {
                    string[] datensatz = lines[i + 1].Split(';'); // aktuelle Zeile in Spalten aufteilen, die aktuelle Datenzeile (ohne Kopfzeile) an den Semikolons trennen
                                                                 // und in ein Array umwandeln, sodass jede Spalte ein eigenes Element ist.

                    for (int j = 0; j < werte.GetLength(1); j++) // Spalten durchgehen
                    {                        
                        werte[i, j] = datensatz[j]; // Wert in das 2D-Array speichern
                    }
                }
                // Ausgabe
                System.Console.WriteLine(" {0, 2} | {1, -20} | {2, -20}", ueberschrift[0], ueberschrift[1], ueberschrift[2]);

                // Ausgabe der Datensätze
                for(int i = 0; i < werte.GetLength(0); i++)
                {
                    System.Console.WriteLine(new string('-', 50)); 
                    System.Console.WriteLine(" {0, 2} | {1, -20} | {2, -20}", werte[i, 0], werte[i, 1], werte[i, 2]);                  
                }
                                
            }
            
        }
    }
}