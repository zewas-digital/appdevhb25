using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SheilaMayJaro.Aufgabe41
{
    public class CinemaRevenueExercise
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 41)");
            System.Console.WriteLine();
            //Umsatz eines Kinos herausfinden - 5 Vorstellungsräume, 2-6 Vorstellungen pro Raum 
            //Anzahl der verkauften Tickets pro Vorstellung, sollen in einem JaggedArray gespeichert werden 
            int[][] cinemaRevenue = new int[5][];
            //Saal 1 - 3 Vorstellungen 
            cinemaRevenue[0] = [23, 56, 49];

            //Saal 2 - 4 Vorstellungen
            cinemaRevenue[1] = [84, 13, 7, 71];

            //Saal 3 - 2 Vorstellungen 
            cinemaRevenue[2] = [59, 16];

            //Saal 4 - 6 Vorstellungen 
            cinemaRevenue[3] = [31, 82, 68, 27, 19, 46];

            //Saal 5 - 2 Vorstellungen 
            cinemaRevenue[4] = [50, 36, 29, 43, 76];

            for (int y = 0; y < cinemaRevenue.Length; y++)
            {
                Console.Write($"Saal {y+1}: ");
                for (int x = 0; x < cinemaRevenue[y].Length; x++)
                {
                    Console.Write($"{cinemaRevenue[y][x]}    ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Ticketverkauf der einzelnen Kinosäle:");
            TicketsSalePerCinemaHall(cinemaRevenue);
            Console.WriteLine();

            TotalTicketsSale(cinemaRevenue);
            Console.WriteLine();
            Console.WriteLine("Durchschnittlicher Ticketverkauf der einzelnen Säle:");
            AverageSoldTicketsPerCinemaHall(cinemaRevenue);
            Console.WriteLine();
            AverageSoldTickets(cinemaRevenue);
            System.Console.WriteLine();
            BestSellingMovieShowPerHall(cinemaRevenue);
            System.Console.WriteLine();
            BestSellingMovieShow(cinemaRevenue);
            Console.WriteLine();
            LeastSellingMovieShowPerHall(cinemaRevenue);
            Console.WriteLine();
            LeastSellingMovieShow(cinemaRevenue);
        }
        public static void TicketsSalePerCinemaHall(int[][] tickets) //Die Anzahl der verkauften Tickets pro Raum und insgesamt.
        {
            int cinemaHallTicketsSales = 0;
            for (int y = 0; y < tickets.Length; y++)
            {
                for (int x = 0; x < tickets[y].Length; x++) //auf den Index der y-Achse bezogen
                {
                    cinemaHallTicketsSales += tickets[y][x];

                }
                Console.WriteLine($"Im Saal {y + 1} sind gesamt {cinemaHallTicketsSales} Tickets verkauft worden.");
            }
        }
        public static void TotalTicketsSale(int[][] tickets)
        {
            int totalTicketsSale = 0;
            int cinemaHallTicketsSales = 0;
            for (int y = 0; y < tickets.Length; y++)
            {
                for (int x = 0; x < tickets[y].Length; x++) //auf den Index der y-Achse bezogen
                {
                    cinemaHallTicketsSales += tickets[y][x];

                }
                totalTicketsSale += cinemaHallTicketsSales;
            }
            Console.WriteLine($"Insgesamt sind {totalTicketsSale} Tickets verkauft worden.");
        }
        public static void AverageSoldTicketsPerCinemaHall(int[][] tickets)
        {
            int averageSoldTicketsPerHall = 0;

            for (int y = 0; y < tickets.Length; y++)
            {
                int cinemaHallTicketsSales = 0;
                for (int x = 0; x < tickets[y].Length; x++) //auf den Index der y-Achse bezogen
                {
                    cinemaHallTicketsSales += tickets[y][x];
                }
                averageSoldTicketsPerHall = cinemaHallTicketsSales / tickets[y].Length;
                System.Console.WriteLine($"Im Saal {y + 1} werden durchschnittlich {averageSoldTicketsPerHall} Tickets verkauft.");
            }
        }
        public static void AverageSoldTickets(int[][] tickets)
        {
            int totalTicketsSale = 0;
            int cinemaScreeningTotal = 0;
            for (int y = 0; y < tickets.Length; y++)
            {
                int cinemaHallTicketsSales = 0;
                
                for (int x = 0; x < tickets[y].Length; x++) //auf den Index der y-Achse bezogen
                {
                    cinemaHallTicketsSales += tickets[y][x];
                }
                totalTicketsSale += cinemaHallTicketsSales;
                cinemaScreeningTotal += tickets[y].Length;
            }
           int overallAverageSoldTickets = totalTicketsSale / cinemaScreeningTotal;
            Console.WriteLine($"Im Gesamtdurchschnitt werden {overallAverageSoldTickets} Tickets verkauft.");
        }
        public static void BestSellingMovieShow(int[][] tickets)
        {
            int maxVal = 0;
            foreach (int[] row in tickets)
            {
                foreach (int number in row)
                {
                    if (number > maxVal)
                    {
                        maxVal = number;
                    }
                }
            }
            Console.WriteLine($"Die meistverkaufte Vorstellung hat {maxVal} Tickets verkauft.");
        }
        public static void BestSellingMovieShowPerHall(int[][] tickets)
        {

            for (int y = 0; y < tickets.Length; y++)
            {
                int maxValPerHall = 0;
                int show = 0; 

                for (int x = 0; x < tickets[y].Length; x++)
                {
                    if (tickets[y][x] > maxValPerHall)
                    {
                        maxValPerHall = tickets[y][x];
                        show = x; 
                    }
                }
                Console.WriteLine($"Im Saal {y + 1} hat die Vorstellung {show+1} mit {maxValPerHall} Tickets am meisten Umsatz gemacht.");
            }
        }
        public static void LeastSellingMovieShowPerHall(int[][] tickets)
        {
            for (int y = 0; y < tickets.Length; y++)
            {
                int minValPerHall = 100;
                int show = 0; 

                for (int x = 0; x < tickets[y].Length; x++)
                {
                    if (tickets[y][x] < minValPerHall)
                    {
                        minValPerHall = tickets[y][x];
                        show = x; 
                    }
                }
                Console.WriteLine($"Im Saal {y + 1} hat die Vorstellung {show+1} mit {minValPerHall} Tickets am wenigsten Umsatz gemacht.");
            }
        }
        public static void LeastSellingMovieShow(int[][] tickets)
        {
            int minVal = 100;
            foreach (int[] row in tickets)
            {
                foreach (int number in row)
                {
                    if (number < minVal)
                    {
                        minVal = number;
                    }
                }
            }
            Console.WriteLine($"Die am wenigsten verkaufte Vorstellung hat nur {minVal} Tickets verkauft.");
        }
    }
}