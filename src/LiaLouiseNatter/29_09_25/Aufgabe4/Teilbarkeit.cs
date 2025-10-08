using System;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe4
{
    public class Teilbarkeit
    {
        public static void Start()
        {
            System.Console.WriteLine("Teiler: 3");
            System.Console.WriteLine("Intervallstart: 8");
            System.Console.WriteLine("Intervallende: 10");
            
            for (int i = 8; i < 15; i++)
            {
       
                if (i % 3 == 0)
                {
                    System.Console.WriteLine(i++);
                }
                
            }
            

        }
    }
}