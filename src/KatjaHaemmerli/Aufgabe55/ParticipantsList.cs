using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe55
{
    public  class ParticipantsList
    {
        public static void ParticipList()
        {
            string dateipfad = @"C:/Users/haka/DigitalCampus/appdevhb25/src/KatjaHaemmerli/Aufgabe55/beispieltext.txt";

            // StreamReader den Text lesen
            using (StreamReader reader = new StreamReader(dateipfad))
            {
                // ReadLine() liest die nächste Zeile aus der Datei, gibt die Zeile mit return zurück und speichert sie in die variable line.
                string line = reader.ReadLine();  // Die Variable line ist ein Zwischenspeicher, weil ich den Wert für die while-Bedingung und für die Ausgabe brauche.

                System.Console.WriteLine(line);
                
                int nummerierung = 0;
                
                while(line != null) // Solange in der variable line ein Text gespeichert ist, soll dieser auf der Konsole ausgegeben und eine neue Zeile eingelesen werden.
                {
                    
                    line = reader.ReadLine();
                   
                    Console.WriteLine($"{++nummerierung,2}. {line}"); // Es werden immer zwei Zeichen für die Aufzählung reserviert und werden von rechts beginnend mit dem Wert der Variable aufgefüllt.
                    
                    
                }
                System.Console.WriteLine(line);                            
            }
        }
    }
}