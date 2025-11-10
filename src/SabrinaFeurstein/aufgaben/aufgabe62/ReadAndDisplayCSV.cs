using System.Data;
using System.Text.RegularExpressions;
using Microsoft.Win32.SafeHandles;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe62
{

    public class ReadAndDisplayCSV
    {
        public static void Start()
        {
            string path = @"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\aufgabe62\InputAufgabe62.csv";
            string[] rowTemp = File.ReadAllLines(path);

            // Zeilen, die nicht dem Eingabemuster entsprechen, löschen
            int rowAnzahl = 0;
            Regex regex = new Regex(@"^.*;.*;.*$");
            for (int i = 0; i < rowTemp.Length; i++)
            {
                if (regex.IsMatch(rowTemp[i]))
                    rowAnzahl++;
            }
            string[] row = new string[rowAnzahl];
            int k = 0;
            for (int i = 0; i < rowTemp.Length; i++)
            {
                if (regex.IsMatch(rowTemp[i]))
                {
                    row[k] = rowTemp[i];
                    k++;
                }
            }

            // temp = temporärer Array zur Festlegung der Anzahl an Spalten, damit die Array-Länge von lines festgelegt werden kann
            string[] temp = row[0].Split(';');
            string[,] lines = new string[row.Length, temp.Length];
            int[,] breite = new int[row.Length, temp.Length];
            int[] breiteMax = new int[temp.Length];
            int laenge = 0;

            for (int i = 0; i < row.Length; i++)
            {
                string[] column = row[i].Split(';');

                for (int j = 0; j < column.Length; j++)
                {
                    // Kombinieren der beiden Arrays für die Zeilen und Spalten in einen 2-dimensionalen Array
                    lines[i, j] = column[j];

                    // Spaltenbreiten berechnen
                    char[] charArray = column[j].ToCharArray();
                    breite[i, j] = charArray.Length;

                    // Spaltenbreite des längsten Wertes pro Spalte
                    if (breite[i, j] > breiteMax[j])
                        breiteMax[j] = breite[i, j];

                    // Zeilenlänge berechnen / Anzahl der '-' zwischen den Zeilen
                    if (i == row.Length - 1)
                        laenge += breiteMax[j] + 2;
                }
            }
            for (int i = 0; i < lines.GetLength(0); i++)
            {
                for (int j = 0; j < lines.GetLength(1); j++)
                {
                    Console.Write($" {lines[i, j]}");
                    if (j != lines.GetLength(1) - 1)
                    {
                        // Anzahl der Zeichen, die fehlen bis zum Erreichen der Maximalen Spaltenbreite
                        char[] charArray = lines[i, j].ToCharArray();
                        int anzahlZeichen = charArray.Length;
                        while (anzahlZeichen != breiteMax[j])
                        {
                            Console.Write(' ');
                            anzahlZeichen++;
                        }
                        Console.Write(" |");
                    }
                }
                Console.WriteLine();

                if (i != lines.GetLength(0) - 1)
                {
                    for (int j = 0; j < laenge + 2; j++)
                        Console.Write('-');
                }

                Console.WriteLine();
            }
        }

        // Mit StreamReader.ReadToEnd()
        public static void StartAlt()
        {
            string path = @"C:\Users\aau30152\Documents\Eigene Dokumente\Visual studio codes\Digital Campus\appdevhb25\src\SabrinaFeurstein\aufgaben\aufgabe62\InputAufgabe62.csv";
            string input = "";

            using (StreamReader sr = new(path))
            {
                input = sr.ReadToEnd();
            }

            // Zeilen, die nicht dem Eingabemuster entsprechen, löschen
            string[] rowTemp = input.Split("\n");
            int rowAnzahl = 0;
            Regex regex = new Regex(@"^.*;.*;.*$");
            for (int i = 0; i < rowTemp.Length; i++)
            {
                if (regex.IsMatch(rowTemp[i]))
                    rowAnzahl++;
            }
            string[] row = new string[rowAnzahl];
            int k = 0;
            for (int i = 0; i < rowTemp.Length; i++)
            {
                if (regex.IsMatch(rowTemp[i]))
                {
                    row[k] = rowTemp[i];
                    k++;
                }
            }

            // temp = temporärer Array zur Festlegung der Anzahl an Spalten, damit die Array-Länge von lines festgelegt werden kann
            string[] temp = row[0].Split(';');
            string[,] lines = new string[row.Length, temp.Length];
            int[,] breite = new int[row.Length, temp.Length];
            int[] breiteMax = new int[temp.Length];
            int laenge = 0;

            for (int i = 0; i < row.Length; i++)
            {
                string[] column = row[i].Split(';');

                for (int j = 0; j < column.Length; j++)
                {
                    // Kombinieren der beiden Arrays für die Zeilen und Spalten in einen 2-dimensionalen Array
                    lines[i, j] = column[j];

                    // Spaltenbreiten berechnen
                    char[] charArray = column[j].ToCharArray();
                    breite[i, j] = charArray.Length;

                    // Spaltenbreite des längsten Wertes pro Spalte
                    if (breite[i, j] > breiteMax[j])
                        breiteMax[j] = breite[i, j];

                    // Zeilenlänge berechnen / Anzahl der '-' zwischen den Zeilen
                    if (i == row.Length - 1)
                        laenge += breiteMax[j] + 2;
                }
            }
            for (int i = 0; i < lines.GetLength(0); i++)
            {
                for (int j = 0; j < lines.GetLength(1); j++)
                {
                    Console.Write($"{lines[i, j]}");
                    if (j != lines.GetLength(1) - 1)
                    {
                        // Anzahl der Zeichen, die fehlen bis zum Erreichen der Maximalen Spaltenbreite
                        char[] charArray = lines[i, j].ToCharArray();
                        int anzahlZeichen = charArray.Length;
                        while (anzahlZeichen != breiteMax[j])
                        {
                            Console.Write(' ');
                            anzahlZeichen++;
                        }
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine();

                if (i != lines.GetLength(0) - 1)
                {
                    for (int j = 0; j < laenge; j++)
                        Console.Write('-');
                }

                Console.WriteLine();
            }
        }
    }
}