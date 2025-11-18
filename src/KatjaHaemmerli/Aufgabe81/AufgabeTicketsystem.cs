using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe81
{
    public  class AufgabeTicketAnbieter
    {
        public static void Start()
        {
            Konzert acdc = new Konzert("AC DC");
            acdc.Warteschlange.Enqueue("Julia");
            acdc.Warteschlange.Enqueue("Carola");
            acdc.Warteschlange.Enqueue("Jessica");
            acdc.Warteschlange.Enqueue("Ella");

            // Konzert 2
            Konzert ABBA = new Konzert("ABBA");
            ABBA.Warteschlange.Enqueue("Maya");
            ABBA.Warteschlange.Enqueue("Sonja");
            ABBA.Warteschlange.Enqueue("Silvie");
            ABBA.Warteschlange.Enqueue("Reto");

            // Konzert 3
            Konzert Rollingstones = new Konzert("Rollingstones");
            Rollingstones.Warteschlange.Enqueue("Toni");
            Rollingstones.Warteschlange.Enqueue("Markus");
            Rollingstones.Warteschlange.Enqueue("Paul");
            Rollingstones.Warteschlange.Enqueue("Heinz");     

            TicketAnbieter eventim = new TicketAnbieter();       

            eventim.PersonenUndKonzerte.Add(acdc.Warteschlange.Dequeue(), acdc.KonzertName);
            eventim.PersonenUndKonzerte.Add(ABBA.Warteschlange.Dequeue(), ABBA.KonzertName);
            eventim.PersonenUndKonzerte.Add(Rollingstones.Warteschlange.Dequeue(), Rollingstones.KonzertName);
            eventim.PersonenUndKonzerte.Add(ABBA.Warteschlange.Dequeue(), ABBA.KonzertName);

            eventim.AusgabeTicketbesitzerUndKonzerte();
        }
    }
}