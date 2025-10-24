using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe56
{
    public  class ParticipantsList2
    {
        public static void ParticipListTwo()
        {
            string datei1 = @"C:/Users/haka/DigitalCampus/appdevhb25/src/KatjaHaemmerli/Aufgabe55/beispieltext.txt";
            string datei2 = @"C:\Users\haka\DigitalCampus\appdevhb25\src\KatjaHaemmerli\Aufgabe56\neuerSpeicherortText.txt";

            // StreamReader den Text lesen
            using (StreamReader reader = new StreamReader(datei1))
            {
                // ReadLine() liest die nächste Zeile aus der Datei, gibt die Zeile mit return zurück und speichert sie in die variable line.
                string line = reader.ReadLine();  // Die Variable line ist ein Zwischenspeicher, weil ich den Wert für die while-Bedingung und für die Ausgabe brauche.

                // System.Console.WriteLine(line);

                int nummerierung = 0;

                // while (line != null) // Solange in der variable line ein Text gespeichert ist, soll dieser auf der Konsole ausgegeben und eine neue Zeile eingelesen werden.
                // {
                //     line = reader.ReadLine();
                //     Console.WriteLine($"{++nummerierung,2}. {line}"); // Es werden immer zwei Zeichen für die Aufzählung reserviert und werden von rechts beginnend mit dem Wert der Variable aufgefüllt.
                // }

                // Text aus einer Textdatei lesen
                string fileContent = File.ReadAllText(datei1);

                // ausgelesener Text in eine andere Datei speichern
            using (StreamWriter sw = new StreamWriter(datei2))
            {
                    sw.WriteLine(fileContent); // Schreibt den Inhalt in die neue Datei
                System.Console.WriteLine("Der Text wurde in datei2 gespeichert");
            }
                
            }
        }
    }
}