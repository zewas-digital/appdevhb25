using System;
namespace Appdevhb25.SheilaMayJaro.Aufgabe56
{
    public class ParticipantsList2
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 56)");
            System.Console.WriteLine("Datenströme");

            /* 
            Lies den Inhalt einer Textdatei (zB “input.txt”) in dein Programm ein und 
            schreibe die Namen der einzelnen Teilnehmer mit einem fortlaufenden Aufzählungszeichen in eine neue Datei (zB “output.txt”). 
            Schreibe in die letzte Zeile die Anzahl der Teilnehmer.
            */

            using (StreamReader FileReader = new StreamReader(@"C:\Users\JASHE\Documents\DigitalCampus2025\appdevhb25\src\SheilaMayJaro\Aufgabe56\input.txt"))
            {
                string lineOfFile = FileReader.ReadLine();
                int number = 0;

                // System.Console.WriteLine(lineOfFile); //Teilnehmer schonmal ausgeben, damit es bei der nummerierung nicht enthalten ist 
                // System.Console.WriteLine();
                // while (lineOfFile != null)
                // {
                //     lineOfFile = FileReader.ReadLine();
                //     System.Console.WriteLine($"{++number,2} {lineOfFile}");
                // }
                // System.Console.WriteLine();
                // System.Console.WriteLine($"{number} Teilnehmer");

                //Wenn die Daten ausgelesen werden, werden sie gelöscht. Damit der Writer Zugriff hat, habe ich es auskommentiert

                using (StreamWriter Filewriter = new StreamWriter(@"C:\Users\JASHE\Documents\DigitalCampus2025\appdevhb25\src\SheilaMayJaro\Aufgabe56\output.txt"))
                {
                    Filewriter.WriteLine(lineOfFile);
                    Filewriter.WriteLine(); 

                    while (lineOfFile != null)
                    {
                        lineOfFile = FileReader.ReadLine(); 
                        Filewriter.WriteLine($"{++number} {lineOfFile}"); 
                    }
                    Filewriter.WriteLine();
                    Filewriter.WriteLine($"{number} Teilnehmer"); 
                }
            }
        }
    }
}