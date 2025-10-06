using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Malreihen
    {
        public static void Start()
        {
            int y = 3;

            for (int x = 0; x <= 10;x++)
            {
                int z = x * y;
                Console.WriteLine(x + "*" + y + "=" + z);
            }
        }
    }
}
