using System;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe9
{
    public class PrintEmptySquare
    {
        public static void Start()
        {
            System.Console.Write("Größe: ");
            var height = Console.ReadLine();
            int result = Convert.ToInt32(height);

            EmptySquare(result);
        }

        public static void EmptySquare(int result)
        {
            for (int i = 0; i < result; i++)
            {
                for (int j = 0; j < result; j++)
                {
                    if (i == 0 || i == result - 1 || j == 0 || j == result - 1)
                    {
                        System.Console.Write("*");
                    }

                    else
                    {
                        System.Console.Write(" ");
                    }
                }
            System.Console.WriteLine();
            }
            
        }

        
    }
}
