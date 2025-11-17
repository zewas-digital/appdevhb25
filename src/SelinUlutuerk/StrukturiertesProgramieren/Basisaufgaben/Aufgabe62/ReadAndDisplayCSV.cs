using System;
using System.IO;
using System.Threading.Tasks.Dataflow;

namespace Appdevhb25.SelinUlutuerk.Aufgabe62
{
    class ReadAndDisplayCSV
    {
        public static void Start()
        {
            string filePathInput = @"C:\Users\aau28234\Documents\appdevneu\appdevhb25\src\SelinUlutuerk\StrukturiertesProgramieren\Basisaufgaben\Aufgabe62\Input.csv";

            string[] lines = File.ReadAllLines(filePathInput);
            string[] parts = new string[lines.Length];
            string[,] table = new string[lines.Length, parts.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                parts = lines[i].Split(",");
                for (int j = 0; j < parts.Length; j++)
                {
                    table[i, j] = parts[j];
                }
            }

            System.Console.WriteLine(" {0,2} | {1,-20} | {2,-20} ", table[0, 0], table[0, 1], table[0, 2]);

            for (int i = 1; i < table.GetLength(0); i++)
            {
                System.Console.WriteLine(new string('-', 50));
                System.Console.WriteLine(" {0,2} | {1,-20} | {2,-20} ", table[i, 0], table[i, 1], table[i, 2]);
            }
        }
    }
}