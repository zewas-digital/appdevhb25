using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe02
{
    class Malreihen
    {
        public static void Start()
        {
            int x = 0;
            int y = 3;
 
            for (int i = 0; i <= 10; i++, x++)
            {
                int z = x * y;
                Console.WriteLine(x + "*" + y + "=" + z);
            }
        }
    }
}