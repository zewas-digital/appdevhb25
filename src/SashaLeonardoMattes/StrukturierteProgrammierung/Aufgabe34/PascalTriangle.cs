using System;
using System.Dynamic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe34
{

    public class PascalTriangle
    {

        public static void StartPascalTriangle()
        {
            Console.WriteLine("----------Aufgabe 34----------");

            System.Console.WriteLine("Gib eine Zahl ein:");
            int size = Helper.checkUserInputInteger();

            int[,] pascalTriangle = new int[size, size];

            for (int i = 0; i < size; i++) //.GetLength(0) gibt Anzahl der Zeilen (.Lenght würde zeilen*spalten also gesamte Größe zurückgeben)
            {
                for (int j = 0; j < size; j++) //.GetLength(0) gibt Anzahl der Spalten
                {
                    if (i == 0 || j == 0)
                    {
                        pascalTriangle[i, j] = 1;
                    }
                    else
                    {
                        pascalTriangle[i, j] = pascalTriangle[i, j - 1] + pascalTriangle[i - 1, j];
                    }
                }
            }

            Helper.Print2DArrayInteger(pascalTriangle);

        }   
    }
}
