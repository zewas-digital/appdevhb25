using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe56
{
    public  class ParticipantsList2
    {
        public static void ParticipListTwo()
        {
            string datei1 = @"C:/Users/haka/DigitalCampus/appdevhb25/src/KatjaHaemmerli/Aufgabe55/beispieltext.txt";
            string datei2 = @"C:\Users\haka\DigitalCampus\appdevhb25\src\KatjaHaemmerli\Aufgabe56\neuerSpeicherortText.txt";

            // StreamReader: den Text lesen
            using (StreamReader reader = new StreamReader(datei1))
            {
                using (StreamWriter sw = new StreamWriter(datei2))

                {
                    
                    // ReadLine() liest die nächste Zeile aus der Datei, gibt die Zeile mit return zurück und speichert sie in die variable line.
                    string line = reader.ReadLine();  // Die Variable line ist ein Zwischenspeicher, weil ich den Wert für die while-Bedingung und für die Ausgabe brauche.

                    int nummerierung = 0;

                    while (line != null) // Solange in der variable line ein Text gespeichert ist, soll dieser auf der Konsole ausgegeben und eine neue Zeile eingelesen werden.
                    {
                        // ausgelesener Text in eine andere Datei speichern
                        sw.WriteLine($"{++nummerierung,2}. {line}"); // Schreibt den Inhalt in die neue Datei

                        line = reader.ReadLine(); // Liest Zeile für Zeile ein nicht der ganze Text auf einmal
                    }

                }
                
            }
        }
    }
}