using System;

namespace Appdevhb25.NoahHois.Aufgabe12
{
    public static class Fibonacci
    {
        public static void Aufgabe12(int zahl)
        {
            /*Console.Write("Gib mir eine Zahl: ");
             string? input = Console.ReadLine();
             int maxNumber = int.Parse(input ?? "0");*/
            int fibonacciNumber = 0, oldNumber = 1, oldOldNumber = 0;
            for (int i = 0; i < zahl; i++)
            {
                fibonacciNumber = oldNumber + oldOldNumber;
                oldOldNumber = oldNumber;
                oldNumber = fibonacciNumber;
                Console.Write(fibonacciNumber + ",");
            }
            Console.WriteLine();
        }
    }
}