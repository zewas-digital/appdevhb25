using System;
namespace Appdevhb25.SheilaMayJaro.Aufgabe62
{
    public class ReadAndDisplayCSV
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 62)");
            //CSV-Datei - csv steht für comma seperate value 
            string path = @"C:\Users\JASHE\Documents\DigitalCampus2025\appdevhb25\src\SheilaMayJaro\Aufgabe62\Aufgabe62csv-file.csv";
            StreamReader CSVFileReader = new StreamReader(path);
            // using (CSVFileReader)
            // {
            //     string? line = CSVFileReader.ReadLine();
            //     string[] words = line.Split(";");
            //     int j = 0;
            //     string[,] list = new string[words.Length, j];
            //     for (int i = 0; i < words.Length; i++)
            //     {
            //         while (words != null)
            //         {
            //             list[i, j] = words[i];
            //             j++;
            //         }
            //         line = CSVFileReader.ReadLine();
            //         words = line.Split();
            //     }
            // }
            //Beispiel mit Marcel 
            using (CSVFileReader)
            {
                //Datei einlesen
                string input = CSVFileReader.ReadToEnd();

                //prüfen, ob es funktioniert hat 
                System.Console.WriteLine(input);

                //Anhand von Zeilenumbrüchen in Zeilen gespaltet
                string[] lines = input.Split("\n", StringSplitOptions.RemoveEmptyEntries);

                //Auf der Konsole ausgeben 
                foreach (string line in lines)
                {
                    System.Console.WriteLine(line);
                }

                //Die Zeile in Spalten aufteilen 
                string[] columnOne = lines[0].Split(";");

                //Ausgabe der Zeile 0
                foreach (string word in columnOne)
                {
                    System.Console.WriteLine(word);
                }
                //Datensätze in Form von einzelnen Wörtern gespeichert
                string[,] values = new string[lines.Length - 1, columnOne.Length];

                for (int i = 0; i < values.GetLength(0); i++)
                {
                    //um den Spaltenkopf zu überspringen, da dieser in Zeile 48 schon verarbeitet wird, machen wir i+1
                    string[] columns = lines[i + 1].Split(";");
                    for (int j = 0; j < values.GetLength(1); j++)
                    {
                        //0. Zeile von values == 1. Zeile von lines (input-Datei)
                        values[i, j] = columns[j];
                    }
                }
                System.Console.WriteLine("{0,-2} | {1,-20} | {2,-20}", columnOne[0], columnOne[1], columnOne[2]); //erste Zeile 
                for (int i = 0; i < values.GetLength(0); i++)
                {
                    System.Console.WriteLine(new string('-', 50));
                    System.Console.WriteLine($"{values[i,0], -2} | {values[i,1], -20} | {values[i,2], -20}"); //Mit Interpolation ausgeben 
                    // System.Console.WriteLine(" {0,-2} | {1,-20} | {2,-20}", values[i, 0], values[i, 1], values[i, 2]);
                    //Es wird nicht richtig an der Konsole ausgegeben... 
                }
            }
        }
    }
}