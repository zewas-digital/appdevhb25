using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Appdevhb25.MarcelSimma
{
    internal class Teilnehmer3
    {
        public static void Start()
        {
            /*
            Allgemeine Vorgehensweise zur Lösung einer Aufgabe:
              1. Aufgabe vollständig und genau lesen!
              2. Fragen stellen und klären
              3. Teilaufgaben bestimmen, Zweck hiervon?
                   - Komplexität reduzieren
                   - Aufgaben aufteilen
                   - besserer Überblick 
                    --> Am Ende von jeder Teilaufgabe, gibt es ein lauffähiges Zwischenergebnis
                    Pareto Regel auch bekannt als 80-20-Regel: 80 % planen und nachdenken, 20 % der zeit umsetzen (programmieren)

            */


            /*
            Konkrete Vorgehensweise in diesem Beispiel:
              1. Wir betrachten Aufgaben 28 bis 30 gemeinsam.
              2. Wie kann ich die Länge über einen Input bestimmen?
              3. EVA-Prinzip (Eingabe, Verarbeitung, Ausgabe), daher zukünftig immer:
                   3.1. Input richtig einlesen und abspeichern
                        --> Jede Datenquelle ist eine Teilaufgabe
                   3.2. Verarbeitung durchführen und Ergebnisse speichern
                        --> Zerlegen in weitere Teilschritte?
                   3.3. Ergebnisse ausgeben
                        --> Jede Ausgabe (Konsole, Datei, DB) einzeln betrachten
                 Teilaufgaben:
                    a. Anzahl der Teilnehmer einlesen
                    b. geeignete Speicherstruktur für Teilnehmer (Array)
                    c. User Input strings (Console.Readline)
                    d. Verarbeitung des Inputs: richtig speichern
                    e. Ausgabe der Daten auf der Konsole


            Teilaufgabe a: Integer von der Konsole einlesen und speichern
            */

            // Wert einlesen
            string temp = Console.ReadLine();

            // eingelesenen Wert konvertieren - Variante 1 ohne Fehlerbehandlung
            //int anzahlDerTeilnehmer = Convert.ToInt32(temp);

            // eingelesenen WErt konvertieren - Variante 2 mit Fehlerbehandlung
            if (int.TryParse(temp, out int anzahlDerTeilnehmer))
            {
                /* 
                Teilaufgabe b:
                */

                // nur "string" erstellt eine normale Variable vom Typ string
                // "string[]" erstellt ein Array, das Werte vom Typ string speichern kann

                string[] teilnehmer = new string[anzahlDerTeilnehmer];

                /*
                Teilaufgabe c:

                */

                // Index des letzten Elements = Array.Length - 1
                for (int i = 0; i < teilnehmer.Length; i++)
                {
                    // Console.Readline() gibt den Input immer in Form eines Strings zurück.
                    teilnehmer[i] = Console.ReadLine();
                }

                /*
                Teilaufgabe d: Prüfen der richtigen Verarbeitung im Debug Mode

                Teilaufgabe e:
                */

                Console.WriteLine("Teilnehmerliste: ");

                for (int j = 0; j < teilnehmer.Length; j++)
                {
                    Console.WriteLine(teilnehmer[j]);
                }

                Console.WriteLine("Anzahl der Teilnehmer: " + teilnehmer.Length);

            }
            else
            {
                System.Console.WriteLine("Falsche Eingabe!");
            }
        }
    }
}