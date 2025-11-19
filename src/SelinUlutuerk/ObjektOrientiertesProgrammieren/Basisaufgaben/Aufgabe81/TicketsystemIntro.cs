using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Appdevhb25.SelinUlutuerk.Aufgabe81
{
    class Ticketsystem
    {
        private List<Konzert> konzerte = new List<Konzert>();
        private Ticketanbieter anbieter = new Ticketanbieter();

        public static void Start()
        {
            Ticketsystem system = new Ticketsystem();
            system.KonzerteAnlegen();
            system.Ticketkauf();
            system.anbieter.WerWo();
        }

        public void KonzerteAnlegen()
        {
            konzerte.Add(new Konzert("The Weekend"));
            konzerte.Add(new Konzert("Taylor Swift"));
            konzerte.Add(new Konzert("RafCamora"));

            konzerte[0].Warteschlange.Enqueue("Selin");
            konzerte[0].Warteschlange.Enqueue("Max");

            konzerte[1].Warteschlange.Enqueue("Ela");

            konzerte[2].Warteschlange.Enqueue("Lena");
            konzerte[2].Warteschlange.Enqueue("Selin");
        }

        private void Ticketkauf()
        {
            foreach (var konzert in konzerte)
            {
                while (konzert.Warteschlange.Count > 0)
                {
                    string person = konzert.Warteschlange.Dequeue();
                    anbieter.TicketKaufen(person, konzert);
                }
            }
        }
    }
}
