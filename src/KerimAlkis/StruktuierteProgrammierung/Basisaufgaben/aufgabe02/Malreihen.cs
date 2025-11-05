using System;

namespace Appdevhb25.KerimAlkis.Aufgabe02
{
    public class Malreihen
    {
        public static void Start()
        {
            Console.WriteLine("Malreihen\n");
            int reihe = 5;
            for (int i = 0; i < reihe; i++)
            {
                Console.WriteLine($"{i} * {reihe} = " + i * reihe);
            }
        }
    }
}