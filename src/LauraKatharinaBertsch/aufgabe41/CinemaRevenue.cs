using System.Globalization;
using System.Net.Http.Headers;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe41
{
    public class CinemaRevenue
    {
        public static void Start()
        {
            beginsCode();
            makesPerformances();
        }
        public static void beginsCode()
        {

            Console.WriteLine("Wir haben ein Kino und berechnen unsere Tickets:");
            Console.WriteLine();
        }
        public static void makesPerformances()
        {
            Random random = new Random();
            int[][] tickets = new int[5][];

            for (int i = 0; i < tickets.Length; i++)
            {
                int randomVorstellungen = random.Next(2, 7);
                tickets[i] = new int[randomVorstellungen];
                for (int j = 0; j < randomVorstellungen; j++)
                {
                    tickets[i][j] = random.Next(1, 100);
                    Console.WriteLine("Raum " + (i + 1) + ": Vorstellung " + (j + 1) + ": Anzahl der verkauften Tickets: " + tickets[i][j]);
                }
                Console.WriteLine($"Der Durschnitt der Tickets in Raum {i + 1} ist: {averagePerRoom(tickets[i])}");
                Console.WriteLine($"Die meist verkauften Tickets in Raum {i + 1} sind: {mostTicketsPerRoom(tickets[i])}");
                Console.WriteLine($"Die wenigsten verkauften Tickets in Raum {i + 1} sind: {lessTicketsPerRoom(tickets[i])}");

                Console.WriteLine();

            }
            Console.WriteLine();
            allTicketsTogether(tickets);
            allTicketsMost(tickets);
            allTicketsLess(tickets);
            allTicketsAverage(tickets);
            Console.WriteLine();
        }
        public static int mostTicketsPerRoom(int[] ticketsInRoom)
        {
            int mostTickets = 0;
            for (int i = 0; i < ticketsInRoom.Length; i++)
            {
                if (ticketsInRoom[i] > mostTickets)
                {
                    mostTickets = ticketsInRoom[i];
                }
            }
            return mostTickets;

        }
        public static int lessTicketsPerRoom(int[] ticketsInRoom)
        {
            int lessTickets = 100;
            for (int i = 0; i < ticketsInRoom.Length; i++)
            {

                if (ticketsInRoom[i] < lessTickets)
                {
                    lessTickets = ticketsInRoom[i];
                }
            }
            return lessTickets;

        }
        public static int averagePerRoom(int[] ticketsInRoom)
        {
            int average = 0;
            for (int i = 0; i < ticketsInRoom.Length; i++)
            {
                average = average + ticketsInRoom[i];
            }
            return average / ticketsInRoom.Length;
        }
        public static void allTicketsTogether(int[][] tickets)
        {
            int allTickets = 0;
            for (int i = 0; i < tickets.Length; i++)
            {
                for (int j = 0; j < tickets[i].Length; j++)
                {
                    allTickets = allTickets + tickets[i][j];
                }
            }
            Console.WriteLine($"Alle Tickets zusammen sind: {allTickets}");
        }
        public static void allTicketsAverage(int[][] tickets)
        {
            int length = 0;
            int average = 0;
            for (int i = 0; i < tickets.Length; i++)
            {
                for (int j = 0; j < tickets[i].Length; j++)
                {
                    average = average + tickets[i][j];
                    length = length + 1;
                }
            }
            average = average / length;
            Console.WriteLine($"Der Durchschnitt von allen Tickets ist: {average}");
        }
        public static void allTicketsMost(int[][] tickets)
        {
            int room = 0;
            int mostTickets = 0;
            for (int i = 0; i < tickets.Length; i++)
            {
                for (int j = 0; j < tickets[i].Length; j++)
                {
                    if (tickets[i][j] > mostTickets)
                    {
                        mostTickets = tickets[i][j];
                        room = i;
                    }
                }
            }
            Console.WriteLine($"Die meist verkauften Tickets sind in Raum {room + 1}: {mostTickets}");
        }
        public static void allTicketsLess(int[][] tickets)
        {
            int room = 0;
            int lessTickets = 100;
            for (int i = 0; i < tickets.Length; i++)
            {
                for (int j = 0; j < tickets[i].Length; j++)
                {
                    if (tickets[i][j] < lessTickets)
                    {
                        lessTickets = tickets[i][j];
                        room = i;
                    }
                }
            }
            Console.WriteLine($"Die wenigsten verkauften Tickets sind in Raum {room + 1}: {lessTickets}");
        }
    }
}