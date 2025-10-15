using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using Appdevhb25.JulianMatt.Aufgabe01;
using Appdevhb25.JulianMatt.Aufgabe03;

namespace Appdevhb25.JulianMatt.Aufgabe41
{
    public class CinemaRevenue
    {

        public static void Start41()
        {
            int[][] mainArray = Arraycreator();
            Console.Clear();
            Calculation(mainArray);
        }

        public static int[][] Arraycreator()
        {
            int[][] cinemaTickets = new int[5][];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                cinemaTickets[i] = new int[rnd.Next(2, 6)];
                int tempVar = cinemaTickets[i].Length;
                for (int k = 0; k < cinemaTickets[i].Length; k++)
                {
                    cinemaTickets[i][k] = rnd.Next(1, 300);
                }
            }


            return cinemaTickets;
        }

        public static void Calculation(int[][] cinemaTickets)
        {
            double tempsumm = 0;
            double summ = 0;
            double allTogehter;

            // 1. Die Anzahl der verkauften Tickets pro Raum und ingsesamt.
            for (int i = 0; i < 5; i++)
            {
                tempsumm = 0;
                Console.Write("Anzahl der verkauften Tickets pro Raum " + (i + 1) + ": ");
                for (int k = 0; k < cinemaTickets[i].Length; k++)
                {
                    tempsumm = tempsumm + cinemaTickets[i][k];
                    summ = tempsumm;
                }
                Console.WriteLine(summ);
            }
            tempsumm = 0;
            summ = 0;
            for (int i = 0; i < 5; i++)
            {

                for (int k = 0; k < cinemaTickets[i].Length; k++)
                {

                    tempsumm = tempsumm + cinemaTickets[i][k];
                    summ = tempsumm;
                }

            }
            Console.Write("Insgesammt: ");
            Console.WriteLine(summ);
            allTogehter = summ;

            Console.WriteLine();

            // 2. Die durchschnittliche Anzahl der Tickets pro Raum und über alle Räume hinweg.
            tempsumm = 0;
            summ = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Durchschnitt der Verkauften Tickets pro Raum " + (i + 1) + ": ");
                double avg = cinemaTickets[i].Average();
                summ = avg;
                Console.WriteLine(summ);
            }


            allTogehter /= 5;

            Console.Write("Durchschnitt der Verkauften Tickets Insgesammt: ");
            Console.WriteLine(allTogehter);

            Console.WriteLine();

            // 3. Die Vorstellung mt den meisten verkauften Tickets pro Raum und insgesammt
            tempsumm = 0;
            summ = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Die Meisten verkauften Tickets pro Raum " + (i + 1) + ": ");
                double max = cinemaTickets[i].Max();
                summ = max;
                Console.WriteLine(summ);
                if (summ > tempsumm)
                {
                    tempsumm = summ;
                }
            }

            Console.Write("Die Meisten verkauften Tickets insgesamt:");
            Console.WriteLine(tempsumm);

            Console.WriteLine();

            // 4. Die Vorstellung mit den wenigsten verkauften Tickets pro Raum und insgesammt.
            tempsumm = 0;
            summ = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Die wenigsten verkauften Tickets pro Raum " + (i + 1) + ": ");
                double min = cinemaTickets[i].Min();
                summ = min;
                Console.WriteLine(summ);
                if (summ < tempsumm)
                {
                    tempsumm = summ;
                }
            }

            Console.Write("Die wenigsten verkauften Tickets insgesamt:");
            Console.WriteLine(tempsumm);

            Console.WriteLine();

            // Der Umsatz.

            tempsumm = 0;
            summ = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Die Umsatz pro Raum " + (i + 1) + ": ");
                summ = cinemaTickets[i].Sum();
                summ *= 13;
                Console.WriteLine(summ);
                tempsumm = tempsumm + summ;
            }

            Console.Write("Der insgesamte Umsatz: ");
            Console.WriteLine(tempsumm);
        }


    }



}

