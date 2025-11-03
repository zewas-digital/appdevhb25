namespace MarcelSimma.Aufgabe62
{
    public class ProcessNumbers
    {
        public static void Start()
        {

            /*
            Aufgabe 62

            1. Aufgabe lesen und verstehen
            2. offene Fragen klären
            3. Teilaufgaben definieren
            3.1. Daten einlesen aus der Datei
            3.2. Daten in zweidimensionales Array speichern
            3.3. Ausgabe in Tabellenformat


            3.1. Daten einlesen aus der Datei
            */

            string input;

            using (StreamReader reader = new StreamReader("/Users/marcel/Documents/code/Appdevhb25/src/MarcelSimma/Week05/Aufgabe63/input.txt"))
            {
                // Den gesamten Inhalt der Datei auf einmal einlesen. 
                input = reader.ReadToEnd();
            }
            // Prüfen, ob einlesen funktioniert hat. 
            System.Console.WriteLine(input);

            // Den gesamten Inhalt der Datei, welcher in die input Variable gespeichert wurde, anhand von Zeilenumbrüchen in einzelne Zeilen aufteilen.
            // StringSplitOptions.RemoveEmptyEntries sorgt dafür, dass leere Werte nicht in die lines-Variable gespeichert werden.
            string[] lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            // lines speichert 6 Zeilen: einen Spaltenkopf + 5 Datensätze

            // Zeilen auf der Konsole ausgeben
            foreach (string line in lines)
            {
                System.Console.WriteLine(line);
            }

            // Den Spalenkopf in einzelne Spalten aufteilen. Die so erhaltenen Werte sind die Spaltenüberschriften.
            string[] spaltenkopf = lines[0].Split(';');

            foreach (string spalte in spaltenkopf)
            {
                System.Console.WriteLine(spalte);
            }

            // werte speichert nur die 5 Datensätze ohne den Spaltenkopf, daher lines.Length - 1
            string[,] werte = new string[lines.Length - 1, spaltenkopf.Length];


            for (int i = 0; i < werte.GetLength(0); i++)
            {
                // Wir wollen nur Datensätze aus der lines Variable verarbeiten. Der Spaltenkopf soll übersprungen werden. Deswegen i+1
                string[] datensatz = lines[i + 1].Split(';');

                for (int j = 0; j < werte.GetLength(1); j++)
                {
                    // Die 0. Zeile im Werte-Array entspricht der 1. Zeile im Lines Array bzw. der 1. Zeile in der Input-Datei.
                    werte[i, j] = datensatz[j];
                }
            }

            // 3.3. Ausgabe

            // Ausgabe des Spaltenkopfes
            System.Console.WriteLine(" {0,2} | {1, -20} | {2, -20} ", spaltenkopf[0], spaltenkopf[1], spaltenkopf[2]);

            // Ausgabe der Datensätze 
            for (int i = 0; i < werte.GetLength(0); i++)
            {
                System.Console.WriteLine(new string('-', 50));
                System.Console.WriteLine(" {0,2} | {1, -20} | {2, -20} ", werte[i, 0], werte[i, 1], werte[i, 2]);
            }
        }
    }
}
