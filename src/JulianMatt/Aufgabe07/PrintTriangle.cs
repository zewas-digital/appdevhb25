using System;

namespace Appdevhb25.JulianMatt.Aufgabe07
{
    public class PrintTriangle
    {

        public static void Start07()
        {
            Console.WriteLine("Geben sie die größe des Dreiecks an");
            int seitenlaenge = Convert.ToInt32(Console.ReadLine());
            int e = 1;
            Console.WriteLine("Hier ist ihr Dreieck");

            for (int g = 1; g <= seitenlaenge; g++)
            {

                if (g == 1)
                {
                    for (int i = 1; i <= seitenlaenge; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                else if (g > 1 && g < seitenlaenge)
                {
                    int dreiecksLösung = seitenlaenge - e;
                    e++;
                    for (int i = 1; i <= dreiecksLösung; i++)
                    {
                        Console.Write("*");


                    }
                    Console.WriteLine();


                }

                else
                {
                    Console.WriteLine("*");
                }

            }
            
        }

    }
}