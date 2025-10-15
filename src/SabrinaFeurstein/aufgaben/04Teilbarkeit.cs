using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Teilbarkeit
    {
        public static void Start()
        {
            int teiler = 3;
            int start = 8;
            int ende = 14;

            Console.WriteLine("Teiler:" + teiler);
            Console.WriteLine("Intervallstart:" + start);
            Console.WriteLine("Intervallende:" + ende);

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