using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.LiaLouiseNatter.Aufgabe31;
using System.Collections.Immutable;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe33
{
    public class Copy
    {

        public static void Start()
        {
            ArrayChanger();
        }

        public static Array ArrayChanger()
        {
            Random random = new Random();
            int[] randomArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                randomArray[i] += random.Next(1, 9);
                System.Console.Write(randomArray[i]);


            }

            System.Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {

                randomArray[0] = -1;
                System.Console.Write(randomArray[i]);

            }
            return randomArray;
            
                 
        }

       
       
        
        


      

        
    }
}