using System; 
namespace Appdevhb25.SheilaMayJaro.Aufgabe37
{
    public class ArrayHelper
    {
        public static void PrintTwoDIntArray(int[,] array)
        { // GetLength fragt die Länge der jeweiligen Dimension ab 
            for (int i = 0; i < array.GetLength(0); i++) //array.GetLength(0) - das 0 steht für die erste Dimension 
            {
                for (int j = 0; j < array.GetLength(1); j++) //array.GetLength(1) - die 1 steht für die zweite Dimension 
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---"); //als Abtrennung 
        }
    }
}