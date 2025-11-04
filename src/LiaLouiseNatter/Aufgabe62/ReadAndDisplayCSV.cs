using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe62
{
    public class ReadAndDisplayCSV
    {
        public static void Start()
        {
            readCSV();
            
        }

        public static void readCSV()
        {
            string filepath = @"C:\Projekte\Kurs\appdevhb25\src\LiaLouiseNatter\Aufgabe62\input\InputAufgabe62.csv";
            using (StreamReader FileReader = new StreamReader(filepath))
            {
                string[] line = File.ReadAllLines(filepath);
                int counter = 0;
                int rows = line.Length;
                int cols = line[0].Split(";").Length;
                string[,] csvData = new string[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    counter++;
                    string[] csvValues = line[i].Split(";");
                    for (int j = 0; j < cols; j++)
                    {
                        csvData[i, j] = csvValues[j].Trim();
                    }
                }
                writeCsvData(rows, cols, csvData);

            }
        }
        
        public static void writeCsvData(int rows, int cols, string[,] csvData)
        {
            int[] maxLength = new int[cols];
            
            for (int j = 0; j < cols; j++)
            {
                int max = 0;
                for (int i = 0; i < rows; i++)
                {
                    int len = csvData[i, j].Length;
                    if (len > max)
                        max = len;
                }
                maxLength[j] = max;
            }

            int totalLength = maxLength.Sum() + (3 * (cols - 1));

            for (int j = 0; j < cols; j++)
            {
                Console.Write(csvData[0, j].PadRight(maxLength[j]) + (j == cols - 1 ? "" : " | "));
            }
            Console.WriteLine();

            Console.WriteLine(new string('-', totalLength));

            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(csvData[i, j].PadRight(maxLength[j]) + (j == cols - 1 ? "" : " | "));
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', totalLength));
            }
        }


    }
}