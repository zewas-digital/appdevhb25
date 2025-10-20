using System;

namespace Appdevhb25.NoahHois.BonusAufgabe4
{
    public class BubbleSort
    {
        public static void SortArray()
        {
            var random = new Random();
            int n = 20;
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(0, 100);
            }

            for (int end = n - 1; end > 0; end--)
            {
                for (int i = 0; i < end; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        var t = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = t;
                    }
                }
            }

            Console.Write("");
            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                {
                    Console.Write(" ");
                }
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
    }
}