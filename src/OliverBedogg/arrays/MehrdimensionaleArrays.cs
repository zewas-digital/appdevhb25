using System;
using static Appdevhb25.OliverBedogg.arrays.ArrayHelper;

namespace Appdevhb25.OliverBedogg.arrays
{

    public class MehrdimensionaleArrays
    {
        public static void Start()
        {
            Console.WriteLine();
            Console.WriteLine("# Zweidimensionale Arrays:");
            int[,] zweiDArray = new int[3, 4];
            zweiDArray[0, 0] = 34;
            zweiDArray[0, 1] = 23;
            zweiDArray[0, 2] = 12;
            zweiDArray[1, 0] = 45;
            // usw.
            ArrayHelper.print2DIntArray(zweiDArray);
            Console.WriteLine("Länge: " + zweiDArray.Length);
            Console.WriteLine("Länge 1. Dimension: " + zweiDArray.GetLength(0));
            Console.WriteLine("Länge 2. Dimension: " + zweiDArray.GetLength(1));
            Console.WriteLine("---");

            // 2D Array, Matrix
            int[,] mehrdimArray = new int[3, 2]
            {
                { 1, 2 }, // 1. dim: index 0 > 2. dim: index 0, index 1
                { 3, 4 }, // 1. dim: index 1 > 2. dim: index 0, index 1
                { 5, 6 } // 1. dim: index 2 > 2. dim: index 0, index 1
            };
            // wie oben mit gleichen Werten an gleichen Positionen wie zweiDArray befüllt 
            int[,] mehrdimArray2 = new int[3, 3]
            {
                { 34, 23, 12},
                { 45, 0, 0},
                { 0, 0, 0}
            };
            
            zweiDArray[0, 0] = 1;
            zweiDArray[0, 1] = 2;
            ArrayHelper.print2DIntArray(mehrdimArray);


            // Jagged Array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };

            jaggedArray[0][1] = 34;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---");
        }
    }

}