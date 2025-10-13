using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe12
{
    public class Fibonacci
    {

        public static void FibonacciFolge(int number, int number1 = 0, int number2 = 1)
        {
            /*
            int numbernew = number;
            if (number == numbernew)
            {
                System.Console.WriteLine(number1);
                System.Console.WriteLine(number2);
            }
            numbernew--;
            */



            number--;


            if (number1 == 0 && number2 == 1)
            {
                System.Console.WriteLine($"{number1}\n{number2}");
            }
            if (number == 0)
            {
                return;
            }
            else
            {
                int result = number1 + number2;
                System.Console.WriteLine(result);
                FibonacciFolge(number, number2, result);
            }

            
        }

        
    }
}