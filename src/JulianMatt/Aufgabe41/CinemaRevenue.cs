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
            double tempSave = 0;
            double mainSave = 0;
            double allTogehter;

            // 1. Die Anzahl der verkauften Tickets pro Raum und ingsesamt.
            for (int i = 0; i < 5; i++)
            {
                tempSave = 0;
                Console.Write("Anzahl der verkauften Tickets pro Raum " + (i + 1) + ": ");
                for (int k = 0; k < cinemaTickets[i].Length; k++)
                {
                    tempSave = tempSave + cinemaTickets[i][k];
                    mainSave = tempSave;
                }
                Console.WriteLine(mainSave);
            }
            tempSave = 0;
            mainSave = 0;
            for (int i = 0; i < 5; i++)
            {

                for (int k = 0; k < cinemaTickets[i].Length; k++)
                {

                    tempSave = tempSave + cinemaTickets[i][k];
                    mainSave = tempSave;
                }

            }
            Console.Write("Insgesammt: ");
            Console.WriteLine(mainSave);
            allTogehter = mainSave;

            Console.WriteLine();

            // 2. Die durchschnittliche Anzahl der Tickets pro Raum und über alle Räume hinweg.
            tempSave = 0;
            mainSave = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Durchschnitt der Verkauften Tickets pro Raum " + (i + 1) + ": ");
                double avg = cinemaTickets[i].Average();
                mainSave = avg;
                Console.WriteLine(mainSave);
            }


            allTogehter /= 5;

            Console.Write("Durchschnitt der Verkauften Tickets Insgesammt: ");
            Console.WriteLine(allTogehter);

            Console.WriteLine();

            // 3. Die Vorstellung mt den meisten verkauften Tickets pro Raum und insgesammt
            tempSave = 0;
            mainSave = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Die Meisten verkauften Tickets pro Raum " + (i + 1) + ": ");
                double max = cinemaTickets[i].Max();
                mainSave = max;
                Console.WriteLine(mainSave);
                if (mainSave > tempSave)
                {
                    tempSave = mainSave;
                }
            }

            Console.Write("Die Meisten verkauften Tickets insgesamt:");
            Console.WriteLine(tempSave);

            Console.WriteLine();

            // 4. Die Vorstellung mit den wenigsten verkauften Tickets pro Raum und insgesammt.
            tempSave = 1000;
            mainSave = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Die wenigsten verkauften Tickets pro Raum " + (i + 1) + ": ");
                double min = cinemaTickets[i].Min();
                mainSave = min;
                Console.WriteLine(mainSave);
                if (mainSave < tempSave)
                {
                    tempSave = mainSave;
                }
            }

            Console.Write("Die wenigsten verkauften Tickets insgesamt:");
            Console.WriteLine(tempSave);

            Console.WriteLine();

            // Der Umsatz.

            tempSave = 0;
            mainSave = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Die Umsatz pro Raum " + (i + 1) + ": ");
                mainSave = cinemaTickets[i].Sum();
                mainSave *= 13;
                Console.WriteLine(mainSave);
                tempSave = tempSave + mainSave;
            }

            Console.Write("Der insgesamte Umsatz: ");
            Console.WriteLine(tempSave);
        }


    }



}

