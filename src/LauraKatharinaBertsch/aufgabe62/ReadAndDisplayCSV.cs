namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe62
{
    public class ReadAndDisplayCSV
    {
        public static void Start()
        {
            string input = "/home/laura/Documents/appdevhb25/src/LauraKatharinaBertsch/aufgabe62/Input.csv";
            using (StreamReader reader = new StreamReader(input))
            {
                string line = reader.ReadToEnd();

                string[] rows = line.Split('\n');
                string[] columns = rows[0].Split(';');

                string[,] rowsAndColumns = new string[rows.Length, columns.Length];

                for (int i = 0; i < rowsAndColumns.GetLength(0); i++)
                {
                    columns = rows[i].Split(';');
                    for (int j = 0; j < rowsAndColumns.GetLength(1); j++)
                    {
                        rowsAndColumns[i, j] = columns[j];
                    }
                    Console.WriteLine("{0,-2} | {1,-15} | {2}  ", rowsAndColumns[i, 0], rowsAndColumns[i, 1], rowsAndColumns[i, 2]);
                    Console.WriteLine(new string('-', 35));
                }
            }
        }
    }
}