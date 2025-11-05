using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe42
{
    class Reverse
    {
        public static void Start()
        {
            string reverse = "Hallo";

            for(int i = 0; i < reverse.Length; i++)
            {
                Console.Write(reverse[reverse.Length - i - 1]);  
            }
        }

    }
}