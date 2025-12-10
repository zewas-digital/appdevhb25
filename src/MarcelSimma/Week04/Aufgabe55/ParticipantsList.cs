using System.Globalization;

namespace Appdevhb25.MarcelSimma
{
    public class ParticipantsList
    {
        public static void Start()
        {
            /*

            Lies den Inhalt einer Textdatei (zB “input.txt”) in dein Programm ein und gib die Namen der einzelnen Teilnehmer mit einem fortlaufenden Aufzählungszeichen auf der Konsole aus. Achte auf eine passende Formatierung.
 
            input.txt
            Teilnehmer <-- Spaltenüberschrift; die 0. Zeile enthält die Spaltenüberschriften; die danach folgenden Zeilen die Datensätze bzw. Werte.
            Gyula
            Markus
            Eva-Maria
            Bernhard
            Elena
            Berkay
            Michael
            Stefan
            Luca
            Julius
            Sandro
             
            Console Output:
            Shell
            1. Gyula
            2. Marks
            3. Eva
            4. Maria
            5. …


            Vorgehensweise:

            1. Aufgabe komplett lesen und verstehen
            2. Offene Fragen klären
            3. Teilaufgaben bilden
            3.1. Input --> StreamReader
            3.2. Verarbeitung: Nummerierung
            3.3. Output auf der Konsole

            3.1. Input
            */

            string path = "/Users/marcel/Documents/code/Appdevhb25/src/MarcelSimma/Week04/Aufgabe55/input.txt";
            /*
            Wie komme ich zum Pfad: 
              - Rechtsklick auf die Datei im VS Code Explorer
              - Copy Path anklicken; wir brauchen den absoluten Pfad
              - Einfügen im Editor
              
            */

            
            // reader ist ein Objekt vom Typ StreamReader.
            // StreamReader ist eine Klasse, die Konstruktoren, Methoden und Attribute bereitstellt für das Auslesen von Dateien.
            using (StreamReader reader = new StreamReader(path))
            {
                // Solange ReadLine() irgendeinen Text zurückgibt, haben wir das Ende noch nicht erreicht.
                // Wenn ReadLine null zurückgibt, haben wir das Ende der Datei erreicht. 

                // line ist eine Variable, welche die zuletzt ausgelesene Zeile speichert.
                // ReadLine() liest die nächste Zeile aus der Datei, gibt die Zeile mit return zurück und speichert sie in die variable line.
                string? line = reader.ReadLine();
                System.Console.WriteLine(line);
                // Die Variable line ist ein Zwischenspeicher, weil ich den Wert für die while-Bedingung und für die Ausgabe brauche.
                
                int nummerierung = 0;
                line = reader.ReadLine();
                // Solange in der variable line ein Text gespeichert ist, soll dieser auf der Konsole ausgegeben und eine neue Zeile eingelesen werden.
                while (line != null)
                {
                    // Wenn ReadLine() einen Text zurückgibt, geben wir diesen auf der Konsole aus.
                    Console.WriteLine($"{++nummerierung,2}. {line}");
                    // Es werden immer zwei Zeichen für die Aufzählung reserviert und werden von rechts beginnend mit dem Wert der Variable aufgefüllt.
                    
                    // Nachdem wir den Text ausgegeben haben, holen wir uns die nächste Zeile für die nächste Iteration.
                    line = reader.ReadLine();
                }

                System.Console.WriteLine(line);

                /*
                Hinweis zur nächsten Aufgabe: Es können mehrere using-Anweisungen ineinader verschachtelt werden. Jede using-Anweisung kümmert sich um eine Ressource.
                
                using (StreamWriter writer = new StreamWriter())
                {

                }
                */

            }
        }
    }
}