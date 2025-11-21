using System.Collections;
using System.Net.WebSockets;

namespace Appdevhb25.JulianMatt.Aufgabe81
{
    public class TicketAnbieter
    {
        public List<Konzerte> concertes = new List<Konzerte>();
        public Dictionary<string, string> BoughtSomeTicket = new Dictionary<string, string>();

        public void FillTicketsUp()
        {
            concertes.Add(new Konzerte("Lady and The Wolf"));
            concertes.Add(new Konzerte("Attack On Ehren"));
            concertes.Add(new Konzerte("Code Geass"));
            concertes.Add(new Konzerte("Full Metal Alchemist"));


            concertes[0].Queue.Enqueue("Julian");
            concertes[0].Queue.Enqueue("Henry");
            concertes[0].Queue.Enqueue("Jona");

            concertes[1].Queue.Enqueue("Marcel");
            concertes[1].Queue.Enqueue("Maria");

            concertes[2].Queue.Enqueue("Ehren");
            concertes[2].Queue.Enqueue("Armin");
            concertes[2].Queue.Enqueue("Levi");

            concertes[3].Queue.Enqueue("Ed");
            concertes[3].Queue.Enqueue("Al");
        }

        public void QueuePeopleOut()
        {
            for (int j = 0; j < concertes.Count; j++)
            {
                for (int i = 0; i < concertes[j].Queue.Count + 2; i++)
                {
                    string name = concertes[j].Queue.Dequeue();
                    BoughtSomeTicket.Add(name, concertes[j].ConcertName);
                }
            }
        }

        public void PrintOutPeopleWhoGotATicket()
        {
            foreach (var ticket in BoughtSomeTicket)
            {
                System.Console.WriteLine($"Name: {ticket.Key,-10} Konzert: {ticket.Value}");
            }
        }


    }
}
