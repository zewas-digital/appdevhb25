using System;

namespace Appdevhb25.JulianMatt.Aufgabe04
{
    public class Teilbarkeit
    {

        public static void Start04()
        {
            Console.WriteLine("Geben sie eine Teiler Zahl und zwei Zahlen als Intervalle ein (beachte das die erste Zahl kleiner als die zweite sein soll)");
            Console.WriteLine("Teiler");
            int divider = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Erste Zahl");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zweite Zahl");
            int end = Convert.ToInt32(Console.ReadLine());

            if (start > end)
            {

                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("Die Zahlen die ohne Kommastellen sind");
                for (int i = start; i <= end; i++)
                {

                    if (i % divider == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Die Zahlen mit Kommastellen");
                for (int i = start; i <= end; i++)
                {
                    if (i % divider != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}