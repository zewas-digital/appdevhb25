using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe33
{

    public class TwoDArray
    {

        public static void StartTwoDArray()
        {
            Console.WriteLine("----------Aufgabe 33----------");

            Random rndGen = new Random();
            int[,] table = new int[3, 3]; //1. Zeilen, 2. Spalten
            int[] rowSum = new int[3];
            int[] columnSum = new int[3];



            for (int i = 0; i < table.GetLength(0); i++) //.GetLength(0) gibt Anzahl der Zeilen (.Lenght würde zeilen*spalten also gesamte Größe zurückgeben)
            {
                for (int j = 0; j < table.GetLength(1); j++) //.GetLength(0) gibt Anzahl der Spalten
                {
                    table[i, j] = rndGen.Next(1, 101);
                }
            }


            Helper.Print2DArrayInteger(table);
            

            for (int i = 0; i < table.GetLength(0); i++)
            {

                for (int j = 0; j < table.GetLength(1); j++)
                {
                    rowSum[i] += table[i, j];
                    columnSum[j] += table[i, j];
                }
            }

            
            System.Console.WriteLine("Zeilensummen:");
            foreach (var sum in rowSum)
            {
                System.Console.WriteLine(sum);
            }

            System.Console.WriteLine("Spaltensummen:");
            foreach (var sum in columnSum)
            {
                System.Console.WriteLine(sum);
            }
           

        }   
    }
}
