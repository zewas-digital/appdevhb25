using System;

namespace Appdevhb25.SheilaMayJaro.Aufgabe09
{
    public class PrintEmptySquares
    {
        public static void Start()
        {
            int length = 5;
            Console.WriteLine("Aufgabe 9)");

            for (int y = 0; y < length; y++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < length; x++)
                {
                    if (x == 0 || x == 4)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }Console.WriteLine(); 
            }
            for (int y = 0; y < length; y++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
        }
    }
}
