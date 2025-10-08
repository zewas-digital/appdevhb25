using System;

namespace Appdevhb25.JulianMatt.Aufgabe03
{
    public class SummeUeberBereich
    {
        public static void Start03()
        {
            Console.WriteLine("Gib zwei Zahlen als Intervalle ein (beachte das die erste Zahl kleiner als die zweite sein soll)");
            int start = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());

            if (start > end)
            {

                Console.WriteLine("Error");
            }
            else
            {
                int summe = 0;
                for (int i = start; i <= end; i++)
                {
                    summe += i;
                }
                Console.WriteLine("Die summe ist " + summe);
            }
        }
    }
}
