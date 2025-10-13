using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Appdevhb25.JulianMatt.Bonusaufgabe07
{
    public class Faktorialerweitert
    {
        static long Fakultät;
        static long Calculation = 1;
        public static void BonusStart07()
        {
            Input();
            Output();
        }

        public static void Input()
        {
            Console.WriteLine("Geben sie die Anzah der Fakultät an die sie berechnet haben möchten an");
            Fakultät = Convert.ToInt32(Console.ReadLine());
        }

        public static void Output()
        {
            string output;
            for (long j = 1; j <= Fakultät; j++)
            {
                var len = Fakultät.ToString().Length;

                Calculation = 1;
                //distance(j, len);
                for (long i = j; i > 1; i--)
                {
                    Calculation *= i;
                }
                output = String.Format(j + "!:{0," + Fakultät + ":N0}", Calculation);
                Console.WriteLine(output);
            }
        }

        private static void distance(long j, int len)
        {
            string spaces = "";
            for (int i = len; i > 0; i--)
            {
                spaces += " ";
            }
            Console.Write(j + "!:" + spaces);
            if (j < 10)
            {
                Console.Write(" ");
            }
        }


    }
}