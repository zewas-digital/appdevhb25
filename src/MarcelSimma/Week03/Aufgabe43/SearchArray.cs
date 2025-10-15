namespace Appdevhb25.MarcelSimma
{
    public class SearchArray
    {
        public static void Start()
        {
            /*
            Aufgabenstellung:
            Erstelle ein Array mit mindestens 10 verschiedenen Werten. 
            Der Nutzer soll über die Konsole einen Wert im Array suchen können. 
            Wird der Wert gefunden, wird sein Speicherindex ausgegeben. 
            Wird der Wert nicht gefunden, kommt eine Fehlermeldung. 

            1. Aufgabe lesen und verstehen
            2. Offene Fragen klären
            3. Teilaufgaben definieren nach EVA-Prinzip (Eingabe, Verarbeitung, Ausgabe)
                3.1. Eingaben
                    3.1.1. Array mit Wörtern erstellen zum Durchsuchen
                    3.1.2. Wort über Konsole einlesen nachdem wir dann das Array durchsuchen
                    3.1.3. Variable definieren, die den Index speichert, wenn das Wort gefunden wurde
                3.2. Verarbeitung

                3.3 Ausgabe
                    - Index des gefundenen Wortes im Wörter-Array ausgeben
                    - Alternativ: Fehlermeldung ausgeben, wenn das Wort nicht gefunden wurde



            3.1. Eingaben
            */

            // 3.1.1. Array mit Wörtern erstellen
            string[] woerter = ["Apfel", "Birne", "Maus", "Haus", "Blabla"]; // Collection Expression Syntax

            // 3.1.2
            string? wort = Console.ReadLine(); // ? = Nullable Operator: sorgt dafür, dass ich alle möglichen Werte speichern kann, die für einen string zulässig sind UND zusätzlich noch null.

            // 3.1.3
            int indexOfFoundWord = -1; // speichert den Wert des Wortes, wenn es gefunden wurde. 
            // Irgendeine Zahl verwenden, die nicht im Rahmen der Verarbeitung als Array-Indexwert vorkommen könnte: Ein Array Index ist immer eine positive ganze Zahl.
            // -1 bedeutet, dass das Wort nicht gefunden wurde
            // Per Definition ist der Standardzustand "nicht gefunden"

            // Im Debug prüfen, ob Variablen richtig im Arbeitspeicher liegen.

            // 3.2 Verarbeitung
            for (int i = 0; i < woerter.Length; i++)
            {
                if (wort == woerter[i])
                {
                    indexOfFoundWord = i;
                    break;
                }
            }


            // 3.3. Ausgabe

            if (indexOfFoundWord == -1)
            {
                System.Console.WriteLine("Word not found.");
            }
            else
            {
                // System.Console.WriteLine("Word Index: " + indexOfFoundWord + 1);
                // Ausgabe: Word Index: 31

                System.Console.WriteLine("Word Index: " + (indexOfFoundWord + 1));
                // Die klammer um die Integer sorgt dafür, dass diese zuerst addiert und das Ergebnis erst als String verarbeitet wird.
            }


        }
    }
}