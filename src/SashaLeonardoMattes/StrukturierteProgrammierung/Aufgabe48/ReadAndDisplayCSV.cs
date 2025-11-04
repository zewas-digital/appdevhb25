using System;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe48
{

    public class ReadAndDisplayCSV
    {

        public static void StartReadAndDisplayCSV()
        {


            Console.WriteLine("----------Aufgabe 48----------");
            System.Console.WriteLine();

            string input;

            using (StreamReader streamReader = new StreamReader(@"C:\Users\sasha.mattes\Documents\InputAufgabe62.csv"))
            {
                input = streamReader.ReadToEnd();
            }

            string[] lines = input.Split("\n");
            
            int amountCols = lines[0].Split(";").Length;
            string[] col;

            int[] maxColSizes = new int[amountCols];

            string[,] table = new string[lines.Length, amountCols];

            for (int i = 0; i < lines.Length - 1; i++)
            {
                col = lines[i].Split(";");
                for (int j = 0; j < amountCols; j++)
                {
                    if (col[j].Length > maxColSizes[j])
                    {
                        maxColSizes[j] = col[j].Length;
                    }
                    
                    table[i, j] = col[j];
                }
            }

            Helper.Print2DArrayAsTable(table, maxColSizes);
            

        }


    }
}
