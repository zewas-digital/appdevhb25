using System;

namespace Appdevhb25.KerimAlkis.Aufgabe04
{
    public class Teilbarkeit
    {
        public static void Start()
        {
            int teiler = 3;
            int start = 8;
            int ende = 14;
            for (int i = start; i <= ende; i++)
            {
                if (i % teiler == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}