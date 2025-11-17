namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe58
{
    public static class PrintFileFormatted
    {
        public static void Start()
        {
            string input = "/home/laura/Documents/appdevhb25/src/LauraKatharinaBertsch/aufgabe58/input.txt";
            using (StreamReader reader = new StreamReader(input))
            {
                string output = "/home/laura/Documents/appdevhb25/src/LauraKatharinaBertsch/aufgabe58/output.txt";
                using (StreamWriter writer = new StreamWriter(output))
                {
                    string line = reader.ReadToEnd();

                    string[] rows = line.Split('\n');
                    string[] columns = rows[0].Split(' ');

                    string[,] rowsAndColumns = new string[rows.Length, columns.Length];

                    for (int i = 0; i < rowsAndColumns.GetLength(0); i++)
                    {
                        columns = rows[i].Split(' ');
                        for (int j = 0; j < rowsAndColumns.GetLength(1); j++)
                        {
                            rowsAndColumns[i, j] = columns[j];
                        }
                        if (i == 0)
                        {
                            writer.WriteLine("{0,-11} | {1,10} | {2, 6}  ", rowsAndColumns[i, 0], rowsAndColumns[i, 1], rowsAndColumns[i, 2]);
                            writer.WriteLine(new string('-', 35));
                        }
                        else
                        {
                            writer.WriteLine("{0,-11} | {1,10:N2} | {2, 6}  ", rowsAndColumns[i, 0], Convert.ToDecimal(rowsAndColumns[i, 1]), rowsAndColumns[i, 2]);
                            writer.WriteLine(new string('-', 35));
                        }
                    }
                }
            }
        }
    }
}