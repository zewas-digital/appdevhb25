using System.Diagnostics.Contracts;

namespace Appdevhb25.MarcelSimma
{
    public class DataStreamsIntro
    {
        public static void Start()
        {
            // ReadFile();
            WriteFile();
        }
        
        public static void ReadFile() {
            // Using sorgt dafür, dass die Ressource (die Datei) im System als von uns verwendet markiert wird. 
            // Sobald wird den Codeblock wieder verlassen, wird die Ressource (die Datei) wieder freigegeben. 
            // mehr zu Using: https://learn.microsoft.com/de-de/dotnet/csharp/language-reference/statements/using
            using (StreamReader FileReader = new StreamReader("/Users/marcel/Documents/code/Appdevhb25/src/MarcelSimma/Week04/DataStreamsIntro/input.txt"))
            {
                // Mehr zu StreamReader: https://learn.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=net-9.0


                // Mit Peek() kann ich das nächste Zeichen im Steam ausgeben ohne es aus diesem zu löschen.
                int peek = FileReader.Peek();
                Console.WriteLine("Das nächste Zeichen: " + (char)peek);

                // Mit Read() kann man das nächste Zeichen im Stream abrufen. Dieses wird aus dem Stream gelöscht.
                int c = FileReader.Read();
                Console.WriteLine((char)c);

                // Mit ReadLine() kann ich eine ganze Zeile aus dem Stream abrufen. 
                string line = FileReader.ReadLine();
                Console.WriteLine(line);

                // Mit ReadToEnd kann ich alles von der aktuellen Position weg bis zum Ende abrufen.
                string wholeFile = FileReader.ReadToEnd();
                Console.WriteLine(wholeFile);

                // Close() schließt den Stream und gibt die Systemressoruce (die Datei aus der gelesen wird) wieder Frei
                // Close() muss hier nicht explizit aufgerufen werden, wenn der StreamReader innerhalb einer using-Anweisung verwendet wird. 
                FileReader.Close();

            }
        }

        public static void WriteFile()
        {
            // Wenn die Datei noch nicht existiert, wird sie erstellt.
            // Wenn die Datei schon existiert, wird sie überschrieben.
            using (StreamWriter FileWriter = new StreamWriter("/Users/marcel/Documents/code/Appdevhb25/src/MarcelSimma/Week04/DataStreamsIntro/output.txt")) {
                
                // schreibt den Text mit Zeilenumbruch
                FileWriter.WriteLine("Teilnehmer 3");
                FileWriter.WriteLine("Joachim");

                // schreibt den Text ohne Zeilenumbruch am Ende
                FileWriter.Write("Clemens");
                FileWriter.Write("Jakob");
                FileWriter.WriteLine();

                string vorname = "Marcel";
                string nachname = "Simma";
                int alter = 24;

                FileWriter.WriteLine("vorname; nachname; alter");
                FileWriter.WriteLine("{0}; {1}; {2}", vorname, nachname, alter);

                FileWriter.WriteLine($"{vorname}; {nachname}; {alter}");

            }

            Console.WriteLine("fertig");
        }
    }
}