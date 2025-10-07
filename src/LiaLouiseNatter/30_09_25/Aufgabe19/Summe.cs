using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe19
{
    public class Summe
    {
        public static void Start()
        {
            System.Console.WriteLine("Summe von 20 bis 50 addiert: ");
            System.Console.WriteLine("--------------------");
            SummeBerechnen();
        }

        public static void SummeBerechnen()
        {
            int sum = 0;
            for (int i = 20; i <= 50; i++)
            {
                sum += i;
                System.Console.WriteLine($"rechnenweg {sum-i} + {i} = {sum}");
            }

        }

        
    }
}