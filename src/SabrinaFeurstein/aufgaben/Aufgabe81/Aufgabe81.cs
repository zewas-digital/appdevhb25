namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe81
{
    public class Aufgabe81
    {
        public static void Start()
        {
            TicketAnbieter ticketmaster = new TicketAnbieter();

            var konzerte = new List<Konzert>();
            konzerte.AddRange([new Konzert("Sabrina Carpenter"), new Konzert("Chappell Roan"), new Konzert("Conan Gray")]);

            konzerte[0].Personen.Enqueue("Sarah");
            konzerte[0].Personen.Enqueue("Jake");
            konzerte[0].Personen.Enqueue("Tim");

            konzerte[1].Personen.Enqueue("Paula");
            konzerte[1].Personen.Enqueue("Sofia");
            konzerte[1].Personen.Enqueue("Claire");
            konzerte[1].Personen.Enqueue("Mitchell");

            konzerte[2].Personen.Enqueue("Max");
            konzerte[2].Personen.Enqueue("Will");
            konzerte[2].Personen.Enqueue("Jane");

            foreach (var konzert in konzerte)
            {
                while (konzert.Personen.Count > 0)
                {
                    ticketmaster.VerkaufteTickets.Add(konzert.Personen.Dequeue(), konzert.KonzertName);
                }
            }

            foreach (var ticket in ticketmaster.VerkaufteTickets)
            {
                Console.WriteLine(ticket.Key + " - " + ticket.Value);
            }
        }
    }
}