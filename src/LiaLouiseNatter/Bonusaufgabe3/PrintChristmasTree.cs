using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.Bonusaufgabe3
{
    public class PrintChristmasTree
    {
        public static void Start(int size)
        {
            Triangle(size);
            Trunk(size);
        }

        public static void Triangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    // für die spaces links
                    System.Console.Write("-");
                }

                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    // Border des Dreiecks
                    if (i == size || j == 1 || j == 2 * i - 1)
                    {
                        System.Console.Write("xo");
                    }
                    // Füllung des dreiecks
                    else
                    {
                        System.Console.Write("xo");
                    }
                }

                System.Console.WriteLine();
            }
            for (int i = 0; i < size; i++)
            {
                System.Console.Write("0 ");
            }
            System.Console.WriteLine();
        }

        public static void Trunk(int size)
        {
            int trunkHeigt = size / 3;
            int trunkWidth = size / 4;
            for (int i = 0; i < trunkHeigt -1; i++)
            {
                
                for (int j = 1; j < size - trunkHeigt / 2 - 1; j++)
                {
                    System.Console.Write(" ");
                }
                
                
                for (int k = 0; k < trunkWidth +3; k++)
                {
                    System.Console.Write("+");
                }
                System.Console.WriteLine();
                
            }
           
        }

      
    }
}