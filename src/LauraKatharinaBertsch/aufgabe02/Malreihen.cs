using System;
using System.Net.Http.Headers;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe02
{
    public class Malreihen
    {
        public static void Start()
        {
            int product = 0;
            for (int i = 0; i < 11; i++)
            {
                product = 5 * i;
                Console.WriteLine(i + " * 5 = " + product);
            }
        }
    }
}
