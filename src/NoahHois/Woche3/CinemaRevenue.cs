using System;
using System.Security.Cryptography;

namespace Appdevhb25.NoahHois.Aufgabe31
{
    public class CinemaRevenue
    {
        public static void Start31()
        {
            int[][] ticketsPerMovie = new int[5][];

            // Zufälliges bestimmen von Anzahl Vorstellungen pro Raum (inneres Array initialisieren)
            Random random1 = new Random();
            for (int r = 0; r < ticketsPerMovie.Length; r++)
            {
                int i = random1.Next(2, 6);
                ticketsPerMovie[r] = new int[i];  // -> Erzeugt neues Array mit zufälliger Länge (sprich Anzahl Vorstellungen)
                Console.WriteLine($"Vorstellungsräume: {r + 1} Vorstellungen: {i}");
            }

            // Befüllt alle Räume und alle Vorstellungen mit zufälligen Werten (Anzahl verkaufen Karten)
            for (int y = 0; y < ticketsPerMovie.Length; y++)
            {
                for (int x = 0; x < ticketsPerMovie[y].Length; x++)
                {
                    ticketsPerMovie[y][x] = random1.Next(100);
                }
            }


            // Berechnung der Summen
            int sumOfAllTickets = 0;
            for (int j = 0; j < ticketsPerMovie.Length; j++)
            {
                int[] moviesOfRoom = ticketsPerMovie[j];
                int sum = 0;
                for (int i = 0; i < moviesOfRoom.Length; i++)
                {
                    sum += moviesOfRoom[i];
                }
                sumOfAllTickets += sum;
                Console.WriteLine($"Tickets vom Raum {j + 1} : " + sum);
            }
            Console.WriteLine("Anzahl aller Tickets: " + sumOfAllTickets);


            // Berechnung der Durchschnittswerte
            sumOfAllTickets = 0;
            int sumOfMovies = 0;
            for (int j = 0; j < ticketsPerMovie.Length; j++)
            {
                int[] moviesOfRoom = ticketsPerMovie[j];
                int sum = 0;
                for (int i = 0; i < moviesOfRoom.Length; i++)
                {
                    sum += moviesOfRoom[i];
                }
                sumOfAllTickets += sum;
                sumOfMovies += moviesOfRoom.Length;
                Console.WriteLine($"Durchschnittswert vom Raum  {j + 1} : " + (sum / moviesOfRoom.Length));
            }
            Console.WriteLine("Anzahl aller Tickets: " + (sumOfAllTickets / sumOfMovies));

            int tempSave = 0;
            for (int i = 0; i < ticketsPerMovie.Length; i++)
            {
                Console.Write($"Die meist verkauften Tickets {i + 1} Raum: ");
                int max = ticketsPerMovie[i].Max();
                Console.WriteLine(max);
                if (tempSave < max)
                {
                    tempSave = max;
                }
            }
            Console.WriteLine("Insgesamt: " + tempSave);

            tempSave = 100;
            for (int i = 0; i < ticketsPerMovie.Length; i++)
            {
                Console.Write($"Die wenigsten verkauften Tickets im {i + 1} Raum:");
                int min = ticketsPerMovie[i].Min();
                Console.WriteLine(min);
                if (tempSave > min)
                {
                    tempSave = min;
                }
            }
            Console.WriteLine("Insgesamt: " + tempSave);

            double overallTicketKosts = 0;

            for (int i = 0; i < ticketsPerMovie.Length; i++)
            {
                double sum = ticketsPerMovie[i].Sum();
                sum *= 14.50;
                Console.WriteLine($"Insgesammter Umsatz {i + 1} Raum: " + sum);
                overallTicketKosts += sum;
            }
            Console.WriteLine("Insgesamt: " + overallTicketKosts);
        }
    }
}