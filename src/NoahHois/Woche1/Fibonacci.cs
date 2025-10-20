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
            int fibo0 = 0;
            int fibo1 = 1;
            int fibo2 = fibo0 + fibo1;
            Console.WriteLine(fibo0);
            Console.WriteLine(fibo1);
            for (int i = 0; i < zahl - 2; i++)
            {
                fibo2 = fibo0 + fibo1;
                fibo0 = fibo1;
                fibo1 = fibo2;

                Console.WriteLine(fibo2);
                
            }
        }
    }
}