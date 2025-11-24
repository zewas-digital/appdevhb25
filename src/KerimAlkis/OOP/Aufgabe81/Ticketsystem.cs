using System.Security.Cryptography;
using Appdevhb25.KerimAlkis.Aufgabe04;
using Appdevhb25.KerimAlkis.Aufgabe66;

namespace Appdevhb25.KerimAlkis.Aufgabe81
{
    public class Ticketsystem
    {
        public static void Start()
        {
            TicketAnbieter ticketA1 = new TicketAnbieter();

            Konzert konzertA = new Konzert("Jazz");
            Konzert konzertB = new Konzert("HardRock");
            Konzert konzertC = new Konzert("Pop");

            ticketA1.KonzertHinzufuegen(konzertA);
            ticketA1.KonzertHinzufuegen(konzertB);
            ticketA1.KonzertHinzufuegen(konzertC);

            konzertA.PersonHinzufuegen("Anna");
            konzertA.PersonHinzufuegen("Bernd");
            konzertA.PersonHinzufuegen("Cem");

            konzertB.PersonHinzufuegen("Ronja");
            konzertB.PersonHinzufuegen("Tina");

            konzertC.PersonHinzufuegen("Hans");
            konzertC.PersonHinzufuegen("Gunter");
            konzertC.PersonHinzufuegen("Peter");




        }
    }
    public class TicketAnbieter
    {
        public Dictionary<string, Konzert> GekaufteTickets { get; private set; }
        public List<Konzert> Konzerte { get; private set; }
        public TicketAnbieter()
        {
            GekaufteTickets = new Dictionary<string, Konzert>();
            Konzerte = new List<Konzert>();
        }
        public void KonzertHinzufuegen(Konzert konzert)
        {
            Konzerte.Add(konzert);
        }
    }
    public class Konzert
    {
        public string KonzertName;
        public Queue<string> Warteschlange;

        public Konzert(string konzertName)
        {
            KonzertName = konzertName;
            Warteschlange = new Queue<string>();
        }
        public void PersonHinzufuegen(string name)
        {
            Warteschlange.Enqueue(name);
        }
        
    }
}