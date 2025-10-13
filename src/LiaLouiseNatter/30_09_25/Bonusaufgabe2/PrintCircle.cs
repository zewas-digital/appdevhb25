using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.BonusAufgabe2
{
    public class PrintCircle
    {
        public static void Start()
        {

        }

        public static void Circle(int radius)
        {
            for (int gk = 0; gk < radius / 2; gk++)
            {
                for (int ak = 0; ak < radius / 2; ak++)
                {
                    System.Console.Write(" ");
                }

            }
            System.Console.WriteLine("x");

           
        }

            
        
    }
}