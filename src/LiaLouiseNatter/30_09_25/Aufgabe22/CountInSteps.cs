using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe22
{
    public class CountInSteps
    {
        public static void Start()
        {
            CountMiniSteps();
           
        }

        public static void CountMiniSteps()
        {
            // 0.1f = float, ohne f = double
            for (float i = 0f; i <= 100; i += 0.1f)
            {
                // {i:F1} wiviel nach dem Komma
                System.Console.WriteLine($"Result 1 digit = {i:F1}");

                System.Console.WriteLine("Result 3 digit = {0,8:F2}",i);
            
            }
            
                
            
            
            

        }

        
    }
}