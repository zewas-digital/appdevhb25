using System;

namespace Appdevhb25.JulianMatt.Aufgabe09
{
    public class PrintEmptySqare
    {

        public static void Start09()
        {
            Console.WriteLine("Geben sie die Seitenlänge des Quadrates an");
            int seitenlaenge = Convert.ToInt32(Console.ReadLine());


            for (int g = 1; g <= seitenlaenge; g++)
            {

                if (g == 1 || g == seitenlaenge)
                {
                    for (int i = 1; i <= seitenlaenge; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


                else
                {
                    Console.Write("*");
                    for (int i = 1; i <= seitenlaenge - 2; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.WriteLine();

                }
            }
        }

    }
}