using System;
using System.Reflection.Metadata.Ecma335;

namespace Appdevhb25.SheilaMayJaro.Aufgabe19
{
    public class PrimitiveDatatypes
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 19)");
            Console.Write(Sum(20, 50)); 

        }
        public static int Sum(int startNumber, int length)
        {
            int sum = 0;
            int subTotal = startNumber;

            for (int i = startNumber+1; i <= length; i++)
            {
                sum = subTotal + i;
                subTotal = sum; 
            }
            return sum; 
        }
        
    }
}