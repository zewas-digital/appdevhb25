using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.Bonusaufgabe17
{
    public class BerechnungVonPi
    {
        public static void Project()
        {
            Console.Write("How many Numbers of PI? ");
            int count = Convert.ToInt32(Console.ReadLine());
            double piNumber = CalculatePi(count);
            Console.WriteLine("Calculated Pi: " + piNumber);
        }


        public static double CalculatePi(int count)
        {
            double piNumber = 0;

            for (int i = 0; i < count; i++)
            {
                double adder = 4.0 / (2.0 * i + 1.0);
                if (i % 2 == 0)
                {
                    piNumber += adder;
                }
                else
                {
                    piNumber -= adder;
                }
            }
            return piNumber;
        }

        
    }
}