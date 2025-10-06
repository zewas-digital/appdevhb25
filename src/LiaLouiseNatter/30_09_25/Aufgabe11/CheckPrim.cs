using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe11
{
    public class CheckPrim
    {
        public static void Start(int number)
        {
            
            System.Console.WriteLine(PrimCalc(number));
        }

        public static bool PrimCalc(int number)
        {
            bool test = false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    test = false;
                    break;
                }

                test = true;
            }
            return test;
        }
    }
}