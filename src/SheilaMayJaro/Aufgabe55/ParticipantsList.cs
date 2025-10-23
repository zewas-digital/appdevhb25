using System;
namespace Appdevhb25.SheilaMayJaro.Aufgabe55
{
    public class ParticipantsList
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 55)");
            /*
                Lies den Inhalt einer Textdatei (zB “input.txt”) 
                in dein Programm ein und gib die Namen der einzelnen Teilnehmer mit einem fortlaufenden Aufzählungszeichen auf der Konsole aus. 
                Achte auf eine passende Formatierung.
            */
            using (StreamReader FileReader = new StreamReader(@"C:\Users\JASHE\Documents\DigitalCampus2025\appdevhb25\src\SheilaMayJaro\Aufgabe55\input.txt"))
            {
                string? lineOfFile = FileReader.ReadLine();
                int number = 0;

                System.Console.WriteLine(lineOfFile); //Teilnehmer soll nicht nummeriert werden, daher wird es davor schonmal ausgegeben 

                while (lineOfFile != null)
                {
                    lineOfFile = FileReader.ReadLine(); 
                    System.Console.WriteLine($"{++number, 2}. {lineOfFile}"); //GitHub Week03 String.Format
                }
            }
        }
    }
}