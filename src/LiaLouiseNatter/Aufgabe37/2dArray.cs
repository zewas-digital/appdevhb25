using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.LiaLouiseNatterS.Aufgabe37
{

    public class Matrix
    {
        public static void Start()
        {
            Random randomNumber = new Random();
            int[,] table = new int[3, 3];
            int[] rowSum = new int[3];
            int[] columnSum = new int[3];



            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = randomNumber.Next(1, 101);
                }
            }

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    System.Console.Write(table[i, j] + " ");
                }
                System.Console.WriteLine();
            }

            for (int i = 0; i < table.GetLength(0); i++)
            {

                for (int j = 0; j < table.GetLength(1); j++)
                {
                    rowSum[i] += table[i, j];
                    columnSum[j] += table[i, j];
                }
            }


            System.Console.WriteLine("Deine Zeilensummen:");
            foreach (var sum in rowSum)
            {
                System.Console.WriteLine(sum);
            }

            System.Console.WriteLine("Deine Spaltensummen:");
            foreach (var sum in columnSum)
            {
                System.Console.WriteLine(sum);
            }



        }
    
    }  
    
}
