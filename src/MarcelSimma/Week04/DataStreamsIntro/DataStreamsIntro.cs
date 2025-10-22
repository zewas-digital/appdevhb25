using System.Diagnostics.Contracts;
using System.Linq.Expressions;

namespace Appdevhb25.MarcelSimma
{
    public class DataStreamsIntro
    {
        public static void Start()
        {
            //ReadFile();
            WriteFile();
        }
        
        public static void ReadFile() {
            /*
            Using sorgt dafür, dass die Ressource (die Datei) im System als von uns verwendet markiert wird.
            Wenn wir die Datei nicht blockieren würden, könnte ein anderer Nutzer oder Prozess gleichzeitig die Datei bearbeiten. Das wollen wir verhindern. 
            Sobald wir den Codeblock wieder verlassen, wird die Ressource (die Datei) wieder freigegeben. 
            mehr zu Using: https://learn.microsoft.com/de-de/dotnet/csharp/language-reference/statements/using

            Aufbau einer using-Anweisung:

            using (Initialisierung der Systemressource, die vom Using beobachtet werden soll)
            {
                Die Systemressource ist nur innerhalb dieser Klammern verfügbar.
                Irgendwelche Befehle...

            }
            
            Wenn die using-Anweisung verlassen wird, wird die Systemressource immer ordnungsgemäß freigegeben.
            Dies geschieht unabhängig davon, ob der Code erfolgreich ausgeführt wurde oder ob ein Fehler auftrat. 
            
            Ein StreamReader kann auch außerhalb einer using-Anweisung initialisiert werden.

            StreamReader sr = new StreamReader("");
            
            */


            using (StreamReader FileReader = new StreamReader("/Users/marcel/Documents/code/Appdevhb25/src/MarcelSimma/Week04/DataStreamsIntro/input.txt"))
            {
                // Mehr zu StreamReader: https://learn.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=net-9.0


                // Mit Peek() kann ich das nächste Zeichen im Steam ausgeben ohne es aus diesem zu löschen. Der Cursor bleibt an der ursprünglichen Position.
                int peek = FileReader.Peek();
                Console.WriteLine("Das nächste Zeichen: " + peek);

                // Mit Read() kann man das nächste Zeichen im Stream abrufen. Dieses wird aus dem Stream gelöscht. Der Cursor verschiebt sich um ein Zeichen.
                int c = FileReader.Read();
                Console.WriteLine((char)c);

                // Mit ReadLine() kann ich eine ganze Zeile aus dem Stream abrufen. Der Cursor verschiebt sich ans Ende der abgerufenen Zeile.
                string line = FileReader.ReadLine();
                Console.WriteLine(line);

                // Mit ReadToEnd kann ich alles von der aktuellen Position weg bis zum Ende abrufen. Der Cursor verschiebt sich ans Ende der Datei.
                string wholeFile = FileReader.ReadToEnd();
                Console.WriteLine(wholeFile);

                // Close() schließt den Stream und gibt die Systemressoruce (die Datei aus der gelesen wird) wieder frei.
                // Close() muss hier nicht explizit aufgerufen werden, wenn der StreamReader innerhalb einer using-Anweisung verwendet wird. 
                FileReader.Close();

            }
        }

        public static void WriteFile()
        {
            // Wenn die Datei noch nicht existiert, wird sie erstellt.
            // Wenn die Datei schon existiert, wird sie überschrieben.
            using (StreamWriter FileWriter = new StreamWriter("/Users/marcel/Documents/code/Appdevhb25/src/MarcelSimma/Week04/DataStreamsIntro/output.txt"))
            {

                // schreibt den Text mit Zeilenumbruch; vergleichbar mit Console.WriteLine()
                FileWriter.WriteLine("Teilnehmer 3");
                FileWriter.WriteLine("Joachim");

                // schreibt den Text ohne Zeilenumbruch am Ende; verlgeichbar mit Console.Write()
                FileWriter.Write("Clemens");
                FileWriter.Write("Jakob");
                FileWriter.WriteLine();

                string vorname = "Marcel";
                string nachname = "Simma";
                int alter = 24;

                // Die Verkettung von Strings funktioniert wie gewohnt.
                FileWriter.WriteLine("vorname; nachname; alter");
                FileWriter.WriteLine("{0}; {1}; {2}", vorname, nachname, alter);

                FileWriter.WriteLine($"{vorname}; {nachname}; {alter}");

                FileWriter.Close(); // optional
            }

            Console.WriteLine("Fertig!");
        }
    }
}