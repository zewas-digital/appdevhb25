using System;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe3
{
    public class SummeUeberBereich
    {
        public static void Start()
        {
            System.Console.WriteLine("Intervallstart: 8");
            System.Console.WriteLine("Intervallende: 10");
            int result = 0;
            for (int i = 8; i < 11; i++)
            {
                
                result += i;
                
            }
            System.Console.WriteLine("Summe über Intervall: "+result);

        }
    }
}
