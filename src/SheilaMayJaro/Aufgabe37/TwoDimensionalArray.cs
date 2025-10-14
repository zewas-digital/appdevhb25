using System;
using static Appdevhb25.SheilaMayJaro.Aufgabe37.ArrayHelper; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe37
{
    public class TwoDimensionalArray
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 37)");
            int[,] numbers = new int[3, 3]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            //Methode ohne Schleife
            ArrayHelper.PrintTwoDIntArray(numbers);
            int rowSumZero = numbers[0, 0] + numbers[0, 1] + numbers[0, 2];
            int rowSumOne = numbers[1, 0] + numbers[1, 1] + numbers[1, 2];
            int rowSumTwo = numbers[2, 0] + numbers[2, 1] + numbers[2, 2];

            //Methode mit Schleife
            
            Console.WriteLine("Die Zeilensumme von links nach rechts");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {   int rowSum = 0;
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    rowSum += numbers[i, j];
                }
                Console.WriteLine(rowSum);
            }

            //Methode ohne Schleife 
            int columnSumZero = numbers[0, 0] + numbers[1, 0] + numbers[2, 0];
            int columnSumOne = numbers[0, 1] + numbers[1, 1] + numbers[2, 1];
            int columnSumTwo = numbers[0, 2] + numbers[1, 2] + numbers[2, 2];

            //Methode mit Schleife
            
            Console.WriteLine("Die Spaltensumme von oben nach unten"); 
            for (int i = 0; i < numbers.GetLength(0); i++)
            {   int columnSum = 0;
                for (int j = 0; j < numbers.GetLength(1); j++)
                { 
                    columnSum += numbers[j, i];
                }
                Console.WriteLine(columnSum); 
            }
        }
    }
}