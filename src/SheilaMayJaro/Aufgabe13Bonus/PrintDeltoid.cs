using System;

namespace Appdevhb25.SheilaMayJaro.Aufgabe13
{
    public class PrintDeltoid
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 13)");
        }
        public static void PrintRhombus(int length)
        {
            //int half = length / 2;
            for (int y = length; y >= length*-1; y--)
            {
                for (int x = length*-1; x <= length; x++)
                {
                    if (Math.Abs(y) + Math.Abs(x) == length)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine(); 
            }
        }
    }
}