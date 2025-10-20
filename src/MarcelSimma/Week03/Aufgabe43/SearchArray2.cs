namespace Appdevhb25.MarcelSimma
{
    public class SearchArray2
    {
        public static void Start()
        {
            /*
            Aufgabenstellung:
            Erstelle ein Array mit mindestens 10 verschiedenen Werten. 
            Der Nutzer soll über die Konsole einen Wert im Array suchen können. 
            Wird der Wert gefunden, wird sein Speicherindex ausgegeben. 
            Wird der Wert nicht gefunden, kommt eine Fehlermeldung. 
            Der Nutzer soll auch nach einzelnen Silben suchen können. 

            1. Aufgabe lesen und verstehen
            2. Offene Fragen klären
            3. Teilaufgaben definieren nach EVA-Prinzip (Eingabe, Verarbeitung, Ausgabe)
                3.1. Eingaben
                    3.1.1. Array mit Wörtern erstellen zum Durchsuchen
                    3.1.2. Zeichenfolge (Silbe) über Konsole einlesen nachdem wir die Wörter im Array durchsuchen
                3.2. Verarbeitung

                3.3 Ausgabe
                    - Indizes der Wörter in denen die gegebene Zeichenkette enthalten ist


            3.1. Eingaben
            */

            // 3.1.1. Array mit Wörtern erstellen
            string[] woerter = ["Apfel", "Birne", "Maus", "Haus", "Blabla", "USA"]; // Collection Expression Syntax

            // 3.1.2
            string? silbe = Console.ReadLine(); // ? = Nullable Operator: sorgt dafür, dass ich alle möglichen Werte speichern kann, die für einen string zulässig sind UND zusätzlich noch null.

            // Im Debug prüfen, ob Variablen richtig im Arbeitspeicher liegen.

            // 3.2 Verarbeitung
            for (int i = 0; i < woerter.Length; i++)
            {               // Trim entfernt die ersten und letzten Leerzeichen
                            // Aus "  Apfel " würde "Apfel" werden
                if (woerter[i].Trim().ToLower().Contains(silbe.ToLower()) == true)
                // == true ist in diesem Fall optional, da true == true wieder true ergibt. 
                // Beispielwort Apfel:
                //  "Apfel".ToLower().Contains(...)
                //  "apfel".          Contains(...)

                {
                    System.Console.WriteLine(i + 1);
                    // break; kann ich nur verwenden, wenn es maximal ein Ergebnis gibt
                    // Da eine Silbe öfters vorkommen kann, kann es mehrere Ergebnisse geben.
                }
            }

            // Alternative Lösung mit foreach
            foreach (string wort in woerter)
            {
                if (wort.Trim().ToLower().Contains(silbe.ToLower()))
                {
                    System.Console.WriteLine(wort);
                }
            }


            // 3.3. Ausgabe
            
            // Aufgabe: Es soll eine Fehlermeldung ausgegeben werden, wenn die Silbe in keinem Wort gefunden wurde.



        }
    }
}