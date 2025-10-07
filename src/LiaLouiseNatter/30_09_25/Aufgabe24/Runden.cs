using System;
using System.Runtime.Intrinsics.Arm;
using System.Globalization;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe24
{
    public class Runden
    {
        public static void Start()
        {
            Console.Write("Wich number do you want to round? ");
            float number;
            while (!float.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Enter a valid number!");
                Console.Write("Wich number do you want to round? ");
            }

            Console.Write("How many decimal places do you want to round to? ");
            float roundNumber;
            while (!float.TryParse(Console.ReadLine(), out roundNumber))
            {
                Console.WriteLine("Enter a valid number!");
                Console.Write("How many decimal places do you want to round to? ");
            }
            
        }
        public static void KfmRound(float number, int number2, int roundNumber)
        {
            if (roundNumber == 0)
            {
                System.Console.WriteLine("Your rounded number is: " + number2);
            }

            else
            {
                double resultpowed = (int)(number * Math.Pow(10, roundNumber + 1));

                int resultInt = Convert.ToInt32(resultpowed);
                System.Console.WriteLine(resultInt);

                int lastNumber = resultInt % 10;
                System.Console.WriteLine(lastNumber);

                if (lastNumber >= 5)
                {
                    resultInt = resultInt / 10 + 1;
                    double finalResult = resultInt / Math.Pow(10, roundNumber);
                    System.Console.WriteLine("Your rounded number is: " + finalResult);
                }
                
                else
                {
                    resultInt = resultInt / 10;
                    double finalResult = resultInt / Math.Pow(10, roundNumber);
                    System.Console.WriteLine("Your rounded number is: " + finalResult);
                }


            }
            

           
           
        
        }

        
    }
}