using System;
using System.Reflection.Metadata.Ecma335;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe58
{
    public class PrintFileFormatted
    {
        public static void PrintFileFormat()
        {
            string angaben = @"C:\Users\haka\DigitalCampus\appdevhb25\src\KatjaHaemmerli\Aufgabe58\angaben.txt";
            string tabelle = @"C:\Users\haka\DigitalCampus\appdevhb25\src\KatjaHaemmerli\Aufgabe58\tabelle.txt";

            // StreamReader: den Text lesen
            using (StreamReader reader = new StreamReader(angaben))
            {
                using (StreamWriter sw = new StreamWriter(tabelle))
                {
                    string? line = reader.ReadLine();

                    while (line != null) // Solange in der variable line Text(angaben) gespeichert ist: Angaben in der Datei durch gehen 
                    {
                        string[] lineValues = line.Split(", ");
                        
                        sw.WriteLine(new string('-', 34)); // Trennlinie
                        // Werte formatiert in andere Datei(tabelle) speichern
                        sw.WriteLine("| {0,-11}| {1,-10}| {2,-6}|", lineValues[0], lineValues[1], lineValues[2]);
                        sw.WriteLine(new string('-', 34)); // Trennlinie
                       
                        line = reader.ReadLine(); // nächste Zeile zum formatieren durchgehen
                    }
                }                   

            }
        }
    }
}