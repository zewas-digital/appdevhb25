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




        }


    }



}

