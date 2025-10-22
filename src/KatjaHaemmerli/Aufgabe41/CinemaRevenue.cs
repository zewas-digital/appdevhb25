using System.Numerics;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe41
{
    public class CinemaRevenue
    {
        public static void Cinema()
        {
            /*
            Aufgabe 41: CinemaRevenue
            
            Erstelle ein Programm, das den Umsatz eines Kinos berechnet. In unserem Kino gibt es fünf Vorstellungsräume. In jedem laufen zwischen zwei und sechs Vorstellungen pro Abend. Für jeden Raum soll die Anzahl der verkauften Tickets pro Vorstellung in einem Jagged Array gespeichert werden. Befülle das Array mit beliebigen Zahlen für die nachfolgenden Berechnungen:

              1. Die Anzahl der verkauften Tickets pro Raum und insgesamt.
              2. Die durchschnittliche Anzahl der Tickets pro Raum und über alle Räume hinweg. 
              3. Die Vorstellung mit den meisten verkauften Tickets pro Raum und insgesamt.
              4. Die Vorstellung mit den wenigsten verkauften Tickets pro Raum und insgesamt.
            */

            // 5 Zeilen für 5 Räume
            int[][] tickets = new int[5][];
            
            InitVorstellungen(tickets);
            GenerateSoldTickets(tickets);
            CalculateSoldTickets(tickets);
            CalculateAverageSoldTickets(tickets);
            CalculateMinTickets(tickets);
            CalculateMaxTickets(tickets);
        }

        public static void InitVorstellungen(int[][] tickets)
        {
            // Die Anzahl der Vorstellungen pro Raum ist immer unterschiedlich und muss für jede Zeile einzeln initalisiert werden.

            // Wir iterieren über jede Zeile und erstellen in jeder Zeile eine zufällige Anzahl an Vorstellungen
            // i ist der Zeilenindex = aktueller Raum

            Random rnd = new Random();

            for (int i = 0; i < tickets.Length; i++)
            {
                tickets[i] = new int[rnd.Next(2, 7)];
                // 2 ist inkludiert, 7 nicht
            }
        }

        public static void GenerateSoldTickets(int[][] tickets)
        {
            Random rnd = new Random();

            for (int i = 0; i < tickets.Length; i++)
            // i ist die Zeile bzw. der Raum
            {
                for (int j = 0; j < tickets[i].Length; j++)
                // j ist die Vorstellung in der aktuellen Zeile bzw. Raum
                {
                    tickets[i][j] = rnd.Next(0, 101);
                }
            }
        }

        public static void CalculateSoldTickets(int[][] tickets)
        {
            int soldTotalTickets = 0;
            for (int i = 0; i < tickets.Length; i++)
            // i ist die Zeile bzw. der Raum
            {
                int soldTicketsInCurrentRoom = 0;
                for (int j = 0; j < tickets[i].Length; j++)
                // j ist die Vorstellung in der aktuellen Zeile bzw. Raum
                {
                    soldTicketsInCurrentRoom = soldTicketsInCurrentRoom + tickets[i][j];
                }
                Console.WriteLine("Raum: " + i + " Tickets: " + soldTicketsInCurrentRoom);
                soldTotalTickets += soldTicketsInCurrentRoom;
            }
            Console.WriteLine("Insgesamt verkaufte Tickets: " + soldTotalTickets);

        }
        
        public static void CalculateAverageSoldTickets(int[][] tickets)
        {
            int soldTotalTickets = 0;
            int totalVorstellungen = 0;
            for (int i = 0; i < tickets.Length; i++)
            // i ist die Zeile bzw. der Raum
            {
                int soldTicketsInCurrentRoom = 0;
                for (int j = 0; j < tickets[i].Length; j++)
                // j ist die Vorstellung in der aktuellen Zeile bzw. Raum
                {
                    soldTicketsInCurrentRoom = soldTicketsInCurrentRoom + tickets[i][j];
                }
                Console.WriteLine("Raum: " + i + " durchschnittliche Tickets: " + soldTicketsInCurrentRoom/tickets[i].Length);
                soldTotalTickets += soldTicketsInCurrentRoom;
                totalVorstellungen += tickets[i].Length;
            }
            Console.WriteLine("Durchschnittlich verkaufte Tickets: " + soldTotalTickets/totalVorstellungen); 

        }

        public static void CalculateMinTickets(int[][] tickets)
        {
            int minTicketsInAllRooms = 101;
            for (int i = 0; i < tickets.Length; i++)
            // i ist die Zeile bzw. der Raum
            {
                int minTicketsInCurrentRoom = tickets[i][0];
                for (int j = 1; j < tickets[i].Length; j++)
                // j ist die Vorstellung in der aktuellen Zeile bzw. Raum
                {
                    if (tickets[i][j] < minTicketsInCurrentRoom)
                    {
                        minTicketsInCurrentRoom = tickets[i][j];
                    }
                }
                Console.WriteLine("Raum: " + i + " minimale Tickets: " + minTicketsInCurrentRoom);
                if (minTicketsInCurrentRoom < minTicketsInAllRooms)
                {
                    minTicketsInAllRooms = minTicketsInCurrentRoom;
                }

            }
            Console.WriteLine("Durchschnittliche Tickets: " + minTicketsInAllRooms);
        }
        
        public static void CalculateMaxTickets(int[][] tickets)
        {
            int maxTicketsInAllRooms = 0;
            for (int i = 0; i < tickets.Length; i++)
            // i ist die Zeile bzw. der Raum
            {
                int maxTicketsInCurrentRoom = tickets[i][0];
                for (int j = 1; j < tickets[i].Length; j++)
                // j ist die Vorstellung in der aktuellen Zeile bzw. Raum
                {
                    if (tickets[i][j] > maxTicketsInCurrentRoom)
                    {
                        maxTicketsInCurrentRoom = tickets[i][j];
                    }
                }
                Console.WriteLine("Raum: " + i + " minimale Tickets: " + maxTicketsInCurrentRoom);
                if (maxTicketsInCurrentRoom > maxTicketsInAllRooms)
                {
                    maxTicketsInAllRooms = maxTicketsInCurrentRoom;
                }

            }
            Console.WriteLine("Durchschnittliche Tickets: " + maxTicketsInAllRooms);
        }
    }
    
}