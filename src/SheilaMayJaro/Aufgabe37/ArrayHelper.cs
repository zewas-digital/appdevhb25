using System; 
namespace Appdevhb25.SheilaMayJaro.Aufgabe37
{
    public class ArrayHelper
    {
        public static void PrintTwoDIntArray(int[,] array)
        { // GetLength fragt die Länge der jeweiligen Dimension ab 
            for (int y = 0; y < array.GetLength(0); y++) //array.GetLength(0) - das 0 steht für die erste Dimension 
            {
                for (int x = 0; x < array.GetLength(1); x++) //array.GetLength(1) - die 1 steht für die zweite Dimension 
                {
                    Console.Write(array[y, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---"); //als Abtrennung 
        }
    }
}