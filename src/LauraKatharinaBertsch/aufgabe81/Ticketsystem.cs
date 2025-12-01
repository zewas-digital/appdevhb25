using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe81
{
    public class Ticketsystem
    {
        public static Konzert taylorSwift = new Konzert("Taylor Swift");
        public static Konzert alvaroSoler = new Konzert("Alvaro Soler");
        public static TicketAnbieter ticketProvider = new TicketAnbieter();
        public static void Start()
        {
            LineUp();
            TicketPurchase();
            ConcertEdition(ticketProvider.SoldTickets);
        }
        public static void LineUp()
        {
            taylorSwift.queue.Enqueue("Laura");
            taylorSwift.queue.Enqueue("Lia");
            taylorSwift.queue.Enqueue("Jona");
            taylorSwift.queue.Enqueue("Sheila");
            taylorSwift.queue.Enqueue("Noah");

            alvaroSoler.queue.Enqueue("Marcel");
            alvaroSoler.queue.Enqueue("Kerim");
            alvaroSoler.queue.Enqueue("Katja");
            alvaroSoler.queue.Enqueue("Julian");
            alvaroSoler.queue.Enqueue("Sasha");
            alvaroSoler.queue.Enqueue("Sabrina");
            alvaroSoler.queue.Enqueue("Selin");
        }
        public static void ConcertEdition(Dictionary<string, string> soldTickets)
        {
            foreach (KeyValuePair<string, string> soldTicket in soldTickets)
            {
                Console.WriteLine($"{soldTicket.Key,-7} | {soldTicket.Value}");
            }
        }
        public static void TicketPurchase()
        {
            while (taylorSwift.queue.Count > 0)
            {
                ticketProvider.SoldTickets.Add(taylorSwift.queue.Dequeue(), taylorSwift.ConcertName);
            }
            while (alvaroSoler.queue.Count > 0)
            {
                ticketProvider.SoldTickets.Add(alvaroSoler.queue.Dequeue(), alvaroSoler.ConcertName);
            }
        }
    }
}