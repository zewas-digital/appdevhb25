using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe57
{
    public class QuadrierenAufgabe
    {
        public static void Quadrieren()
        {
            string rechenzahlen = @"C:\Users\haka\DigitalCampus\appdevhb25\src\KatjaHaemmerli\Aufgabe57\rechenzahlen.txt";
            string berechnungen = @"C:\Users\haka\DigitalCampus\appdevhb25\src\KatjaHaemmerli\Aufgabe57\berechnungen.txt";

            // Aufgabe: Zahlen nacheinander aus der Textdatei lesen und mit sich selbst multipliziere. Dann Rechenweg mit Ergebnis in andere Datei speichern           

            // StreamReader: den Text lesen
            using (StreamReader reader = new StreamReader(rechenzahlen))
            {

                // ausgelesener Text in andere Datei(berechnungen) speichern
                using (StreamWriter sw = new StreamWriter(berechnungen))
                {
                    string? line = reader.ReadLine();

                    while (line != null) // Solange in der variable line Text(rechenzahlen) gespeichert ist: zahlen in der Datei durch gehen jede einzelne mit sich selbst multiplizieren und Berechnung mit Ergebniss in neue Datei speichern
                    {
                        // int number = int.Parse(line);
                        int number = Convert.ToInt32(line);

                        int sum = number * number;
                        System.Console.WriteLine($"{number} * {number} = {sum}");

                        sw.WriteLine($"{number} * {number} = {sum}"); // Schreibt den die Berechnung mit Ergebniss in die neue Datei
                        line = reader.ReadLine(); // nächste Zeile zur Berechnung aus der Datei(rechenzahlen) lesen

                    }
                }                   

            }
        }
    }
}