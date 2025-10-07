using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe24
{
    public class Runden
    {
        public static void Start()
        {
            Console.Write("Wich number do you want to round? ");
            float number = Convert.ToInt32(Console.ReadLine());
            KfmRound(number);
            
        }
        public static void KfmRound(float number)
        {
            
        }

        
    }
}