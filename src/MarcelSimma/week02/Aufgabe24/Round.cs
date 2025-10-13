namespace Appdevhb25.MarcelSimma.week02
{
    public class Round
    {
        public static void Start(double zahl, int anzahlDerKommastellen)
        {
            /*
              1. Aufgabe ganz lesen und verstehen
              2. offene Fragen klären
              3. Unterteilung in Teilprobleme
                   3.1. Lösen ohne kaufmännisches Runden
                   3.2. kaufmännisches Runden implementieren
              4. Ressourcen bestimmen: 
                   - die Zahl selbst: double
                   - Anzahl der Kommastellen: int  
            */

            /*
            // 3.1.: Vorgehensweise Kommastellen entfernen
            //ich verschiebe das Komma nach rechts; aus 11.11111 wird 1111.111
            int zahlAsInt = (int)(zahl * Math.Pow(10, anzahlDerKommastellen));

            // Mit dem Cast werden alle Stellen hinter dem Komma gelöscht; aus 1111.111 wird 1111
            double zahlAsDouble = (double)zahlAsInt;

            // Komma wird wieder an ursprüngliche Position zurück verschoben; aus 1111 wird 11.11
            Console.WriteLine(zahlAsDouble / Math.Pow(10, anzahlDerKommastellen));
            */

            /*
            3.1. und 3.2.
            */

            // Umwandlung mit einer Kommastelle mehr als notwendig; aus 55.55555 wird 55555
            int zahlAsInt = (int)(zahl * Math.Pow(10, anzahlDerKommastellen + 1));

            // Extraktion der letzten Ziffer; 55555 % 10 = 5
            int einerstelle = zahlAsInt % 10;

            zahlAsInt /= 10;
            // zahlAsInt = zahlAsInt / 10;

            // auf- oder abrunden?
            if (einerstelle < 5)
            {
                // gewünschtes Ergebnis: 55,56
            }
            else
            {
                zahlAsInt += 1;
            }
            Console.WriteLine(zahlAsInt / Math.Pow(10, anzahlDerKommastellen));
        }
    }
}