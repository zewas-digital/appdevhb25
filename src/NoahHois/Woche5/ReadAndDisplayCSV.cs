using System.Data;

namespace Appdevhb25.NoahHois.Aufgabe62
{
    public class ReadAndDisplayCSV
    {
        public static void Start()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\NOHO\Downloads\InputAufgabe62.csv"))
            {
                // Input einlesen
                string input = reader.ReadToEnd();
                string[] lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                int amoutColumns = lines[0].Split(';').Length;
                string[] CellValue;
                int[] maxCellWidth = new int[amoutColumns];
                string[,] table = new string[lines.Length, amoutColumns];

                // Input so verarbeiten, dass die Werte im table-Array gespeichert sind.
                for (int row = 0; row < lines.Length; row++)
                {
                    CellValue = lines[row].Split(';');
                    for (int column = 0; column < amoutColumns; column++)
                    {
                        table[row, column] = CellValue[column];

                    }
                }


                // Schleife, um die längsten Werte zu finden
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    if (maxCellWidth[0] <= table[i, 0].Length)
                    {
                        maxCellWidth[0] = table[i, 0].Length;
                    }
                    if (maxCellWidth[1] <= table[i, 1].Length)
                    {
                        maxCellWidth[1] = table[i, 1].Length;
                    }
                    if (maxCellWidth[2] <= table[i, 2].Length)
                    {
                        maxCellWidth[2] = table[i, 2].Length;
                    }
                }


                // Schleife für die Ausgabe
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    Console.WriteLine(new string('─', maxCellWidth[0] + 1) + "┼" + new string('─', maxCellWidth[1] + 2) + "┼" + new string('─', maxCellWidth[2]));

                    Console.WriteLine("{0, -" + maxCellWidth[0] + "} │ {1, " + maxCellWidth[1] + "} │ {2, -" + maxCellWidth[2] + "}", table[i, 0], table[i, 1], table[i, 2]);
                }
            }
        }
    }
}