using System;
using System.Linq;

namespace Appdevhb25.JonaSchnell.Aufgabe35
{
    public class Aufgabe35
    {
        public static void Start35()
        {
            var random = new Random();
            int n = 20;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(0, 100);
            }


            for (int ende = n - 1; ende > 0; ende--)
            {
                for (int i = 0; i < ende; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        var t = a[i]; a[i] = a[i + 1]; a[i + 1] = t;
                    }
                }
            }

            Console.Write("");
            for (int i = 0; i < n; i++)
            {
                if (i > 0) Console.Write(" ");
                {
                    Console.Write(a[i]);
                }
            }
            Console.WriteLine();
        }
    }
}