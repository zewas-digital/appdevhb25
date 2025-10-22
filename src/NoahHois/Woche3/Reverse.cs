using System;

namespace Appdevhb25.NoahHois.Aufgabe32
{
    public class Reverse
    {
        public static void Start()
        {
            string message1;

            message1 = "Hallo";

            for (int i = message1.Length; i > 0; i--)
            {
                Console.WriteLine(message1[i - 1]);
            }
        }
    }
}