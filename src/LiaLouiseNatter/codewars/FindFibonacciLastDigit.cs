using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.codewars
{
    public class FindFibonacciLastDigit
    {

        public static void FibonacciFolgeLast(int index)
        {
            int num1 = 0, num2 = 1, sum = 0;
            for (int i = 0; i < index; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                System.Console.WriteLine(sum);
            }



            
            
        }

        
    }
}