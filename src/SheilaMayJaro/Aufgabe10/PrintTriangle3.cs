using System;
using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SheilaMayJaro.Aufgabe10
{
    public class PrintTriangle3
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 10)");

        }
        public static void PrintTriangle(int length)
        {
            int c = length * 2 - 1;

            for (int y = 0; y < length - 1; y++)
            {
                for (int x = (length * -1) +1; x < length; x++)
                {
                    if (Math.Abs(x) == Math.Abs(y))
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
            for (int Hy = 0; Hy < c; Hy++)
            {
                Console.Write("x");
            }
        }
    }
}

