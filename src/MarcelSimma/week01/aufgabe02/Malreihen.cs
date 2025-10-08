using System;

namespace Appdevhb25.MarcelSimma.Aufgabe02
{
    public class Malreihen
    {

        public static void Start()
        {
            int reihe = 3;

            for (int i = 0; i <= 10; i++)
            {
                int product = reihe * i;
                Console.WriteLine(" " + product);
            }
            
        }
    }
}