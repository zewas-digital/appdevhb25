using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe10
{
    public class Triangle
    {
        public static void Start()
        {
            
        }

        public static void PrintTriangle(int length)
        {
            double hypothenuse = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(length, 2));
            hypothenuse++;
            for (int i = 1; i <= length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    // für die spaces links
                    System.Console.Write("-");
                }
                for (int j = 1; j <= (2 * i); j++)
                {
                    if (i == length || j == 1 || j == 2 * i - 1)
                    {
                        System.Console.Write("x");
                    }
                    // spaces rechts
                    else
                    {
                        System.Console.Write("-");
                    }
                }
                System.Console.WriteLine();
            }
            
        }
    }
}