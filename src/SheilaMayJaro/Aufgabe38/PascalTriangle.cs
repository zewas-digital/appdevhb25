using System;
using System.Runtime.CompilerServices;
using static Appdevhb25.SheilaMayJaro.Aufgabe37.ArrayHelper; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe38
{
    public class PascalTriangle
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 38)");
            // Console.WriteLine("Wie groß darf das Pascal Dreieck denn sein?");
            // string temp = Console.ReadLine();
            // int length = Convert.ToInt32(temp); 
            int[,] pascalTriangle = new int[10, 10];

            //array[zeilenIndex, spaltenIndex]

            for (int y = 0; y < pascalTriangle.GetLength(0); y++)
            {
                for (int x = 0; x < pascalTriangle.GetLength(1); x++)
                {

                    if (y == 0)
                    {
                        pascalTriangle[y, x] = 1;
                    }
                    else if (x == 0)
                    {
                        pascalTriangle[y, x] = 1;
                    }
                    else
                    {
                        pascalTriangle[y, x] = pascalTriangle[y-1, x] + pascalTriangle[y, x-1]; 
                    }
                }
            }
            for (int y = 0; y < pascalTriangle.GetLength(0); y++) //array.GetLength(0) - das 0 steht für die erste Dimension 
            {
                for (int x = 0; x < pascalTriangle.GetLength(1); x++) //array.GetLength(1) - die 1 steht für die zweite Dimension 
                {
                    Console.Write("{0,10}", pascalTriangle[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}