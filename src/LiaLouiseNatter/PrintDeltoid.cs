using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.BonusAufgabe
{
    public class PrintDeltoid
    {
        public static void Start()
        {
            System.Console.Write("Größe: ");

            var height = Console.ReadLine() ?? string.Empty;
            int result = Convert.ToInt32(height);

            System.Console.Write("Zeichen: ");
            var character = Console.ReadLine() ?? string.Empty;


            for (int i = 1; i <= result; i++)
            {

                for (int k = 1; k <= i ; k++)
                {
                    System.Console.Write(character);
                }

                System.Console.WriteLine();
            }
            
           
            

        }
    }
}