using System;
using System.Text;
namespace Appdevhb25.SheilaMayJaro.Aufgabe58VertiefteAufgabe
{
    public class PrintFileFormatted
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 58)");
            /* 
            Lies die Datensätze aus einer Datei ein und schreibe diese als schön formatierte Tabelle in eine Output-Datei. 
            */


            using (StreamReader fileReader = new StreamReader(@"C:\Users\JASHE\Documents\DigitalCampus2025\appdevhb25\src\SheilaMayJaro\Aufgabe58VertiefteAufgabe\input.txt"))
            {
                using (StreamWriter fileWriter = new StreamWriter(@"C:\Users\JASHE\Documents\DigitalCampus2025\appdevhb25\src\SheilaMayJaro\Aufgabe58VertiefteAufgabe\output.txt"))
                {
                    // string? lineOfFile = FileReader.ReadLine();
                    //System.Console.WriteLine(lineOfFile);

                    // while (lineOfFile != null)
                    // {
                    //     System.Console.WriteLine(lineOfFile);
                    //     lineOfFile = FileReader.ReadLine(); 
                    // }
                    string? line = fileReader.ReadLine();
                    string[] words = new string[0];
                    string d = "😊";
                    int count = 0; 
                    
                    while (line != null)
                    {
                        count++; 
                        words = line.Split(" "); //die Zeile wird in Worte gespalten, gespalten durch das Leerzeichen (" ")
                        for (int i = 0; i < words.Length; i++)
                        {
                            
                            if (i == 0)
                            {
                                fileWriter.Write($"{words[i], -10} | ");
                            }
                            else if (i == 2)
                            {
                                fileWriter.Write($"{words[i], 5}");
                            }
                            else
                            {
                                fileWriter.Write($"{words[i], 6} | ");
                            }
                        }
                        line = fileReader.ReadLine();
                        fileWriter.WriteLine();
                        if (count <= 3)
                        {
                            fileWriter.WriteLine("---------------------------");
                        }
                    }
                }
            }
        }
    }
}