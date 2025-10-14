using System;

namespace Appdevhb25.SheilaMayJaro.Aufgabe02
{
    public class TimeTable
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 2)"); 
            int a = 3;
            int c = 0;
            for (int i = 0; i <= 10; i++)
            {
                c = a * i;
                Console.WriteLine($"{a} * {i} = {c}");
            }
        }
    }
}
