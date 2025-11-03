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

                System.Console.WriteLine(input);
                // StringSplitOptions.Remove sorgt dafür, dass leere Zeilen nicht in die lines-Variable gespeichert werden
                string[] lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);

                // Zeilen auf der Konsole ausgeben
                foreach (string line in lines)
                {
                    System.Console.WriteLine(line);
                }

                // Die Zeilen in einzelne Spalten aufteilen
                string[] spaltenkopf = lines[0].Split(';');

                foreach (string spalte in spaltenkopf)
                {
                    System.Console.WriteLine(spalte);
                }

                // Datensätze in Form von einzelne Spalte aufteilen
                string[,] werte = new string[lines.Length - 1, spaltenkopf.Length];

                for (int i = 0; i < werte.GetLength(0); i++) // int i = 1 um Zeilenkopf zu überspringen
                {
                    string[] datensatz = lines[i + 1].Split(';');

                    for (int j = 0; j < werte.GetLength(1); j++)
                    {
                        // Die 0. Zeile im Wert -Array entspricht der 1. Zeile im Lines Array bzw. der 1. Zeile in der Input-Datei
                        werte[i, j] = datensatz[j];
                    }
                }
                // Ausgabe
                System.Console.WriteLine(" {0, 2} | {1, -20} | {2, -20}", spaltenkopf[0], spaltenkopf[1], spaltenkopf[2]);

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