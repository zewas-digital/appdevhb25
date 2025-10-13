using System;

namespace Appdevhb25.NoahHois.Aufgabe5
{
    public class PrintLine
    {
        public static void Aufgabe5()
        {
            Console.WriteLine("Wie viele x hättest du gerne?");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x ; i++)
            {
                Console.Write("x");
            }
        }
    }
}