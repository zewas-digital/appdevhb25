using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using Appdevhb25.SheilaMayJaro.Aufgabe03;

namespace Appdevhb25.SheilaMayJaro.Aufgabe12
{
    public class Fibonacci
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 12)");
            FibonacciMethod(10);
        }
        public static void FibonacciMethod(int length)
        {
            int n0 = 1;
            int n1 = 1;
            Console.WriteLine(n0);
            Console.WriteLine(n1);
            for (int i = 3; i <= length; i++)
            {
                int x = n0 + n1;
                n0 = n1;
                n1 = x;
                Console.WriteLine(x);
            } 
        }
    }
}