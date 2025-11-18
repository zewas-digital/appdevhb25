using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe81
{
    class Konzert
    {
        public string Name { get; set; }
        public Queue<string> Warteschlange { get; set; }

        public Konzert(string name)
        {
            Name = name;
            Warteschlange = new Queue<string>(); 
        }
        public override string ToString()
        {
            return Name;
        }
    }

    class Ticketanbieter
    {
        // Dictionary für Person und Konzert
        private Dictionary<string, string> gekaufteTickets = new Dictionary<string, string>();

        public void TicketKaufen(string person, Konzert konzert)
        {
            gekaufteTickets[person] = konzert.Name;
        }

        public void WerWo()
        {
            Console.WriteLine("Übersicht: Wer geht auf welches Konzert?");

            foreach (var t in gekaufteTickets)
            {
                Console.WriteLine($"{t.Key} geht auf das {t.Value} Konzert.");
            }
        }
    }
}