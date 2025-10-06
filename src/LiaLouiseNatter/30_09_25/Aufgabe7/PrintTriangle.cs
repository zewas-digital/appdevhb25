using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe7
{
    public class PrintTriangle
    {
        public static void Start()
        {
            System.Console.Write("Größe: ");

            var height = Console.ReadLine();
            int result = Convert.ToInt32(height);
 
            System.Console.Write("Zeichen: ");
            var character = Console.ReadLine();


            for (int i = 0; i <= result; i++)
            {
                for (int j = 0; j < result - i; j++)
                {
                    System.Console.Write(character);
                }
                System.Console.WriteLine();
            }
            
           
            

        }
    }
}