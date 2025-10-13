using System;

namespace Appdevhb25.NoahHois.Aufgabe4
{
    public class Teilbarkeit
    {
        public static void Aufgabe4()
        {
            int intervallstart = 8;
            int intervallende = 14;
            int teiler = 3;
            for (int i = intervallstart; i <= intervallende; i++)
            {
                if (i % teiler == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}