using System;
using System.IO;
using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe62
{
    public class ReadAndDisplayCSV
    {
        public static void Start62()
        {
            PartList();
        }

        public static void PartList()
        {
            string firstString;
            using (StreamReader FileReader = new StreamReader(@"C:\Users\majn\Documents\Kurs\appdevhb25\src\JulianMatt\Aufgabe62\input.csv"))
            {
                firstString = FileReader.ReadToEnd();
            }
                string[] lines = firstString.Split('\n', StringSplitOptions.RemoveEmptyEntries);

                string[] spaltenKopf = lines[0].Split(';');

                string[,] werte = new string[lines.Length - 1, spaltenKopf.Length];

                for (int i = 0; i < werte.GetLength(0); i++)
                {
                    string[] spalts = lines[i + 1].Split(";");

                    for (int j = 0; j < werte.GetLength(1); j++)
                    {
                        werte[i, j] = spalts[j];
                    }


                }
                System.Console.WriteLine(" {0,2} | {1, -20} | {2, -20} ", spaltenKopf[0], spaltenKopf[1], spaltenKopf[2]);
                
                for (int i = 0; i < werte.GetLength(0); i++)
                {
                    System.Console.WriteLine(new string('-', 40));
                    System.Console.WriteLine(" {0,2} | {1, -20} | {2, -20} ", werte[i, 0], werte[i, 1], werte[i, 2]);
                    
                }

            
        }
    }
}
