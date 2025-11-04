using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe63
{
    public class ProcessNumbers
    {
        public static void Start(int[] numbers)
        {

            int[] countAndSum = CountNegativesSumPositives(numbers);
            printer(countAndSum);
        }

        public static int[] CountNegativesSumPositives(int[] numbers)
        {
            int positivesSum = 0;
            int negativesCount = 0;
            int[] countAndSum = new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    positivesSum += numbers[i];
                }
                else
                {
                    negativesCount++;
                }
                countAndSum[0] = negativesCount;
                countAndSum[1] = positivesSum;

            }
            return countAndSum;
        }
        
        public static void printer(int[] countAndSum)
        {
            System.Console.Write($"[{countAndSum[0]},{countAndSum[1]}]");
        }


    }
}