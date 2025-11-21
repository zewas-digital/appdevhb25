namespace Appdevhb25.SheilaMayJaro.Aufgabe81
{
    public class TicketSystem
    {
        public static void Start()
        {
            //Übung zu Queue
            System.Console.WriteLine("Aufgabe 81)");
            //Programmablauf 1: Simuliere im Programm die Einreihung mehrerer Personen für mehrere Konzerte bevor der Verkauf beginnt
            Concert ateez = new Concert();
            ateez.AddToTicketSaleQueue("Martina");
            ateez.AddToTicketSaleQueue("Magdalena");
            ateez.AddToTicketSaleQueue("Vici");
            ateez.AddToTicketSaleQueue("Stephanie");
            ateez.AddToTicketSaleQueue("Florian");
            ateez.AddToTicketSaleQueue("Ivan");
            Concert taylorSwift = new Concert();
            taylorSwift.AddToTicketSaleQueue("Sarah");
            taylorSwift.AddToTicketSaleQueue("Cornelia");
            taylorSwift.AddToTicketSaleQueue("Mira");
            taylorSwift.AddToTicketSaleQueue("Niklas");
            taylorSwift.AddToTicketSaleQueue("Maya");
            taylorSwift.AddToTicketSaleQueue("Leonardo");
            Concert twice = new Concert();
            twice.AddToTicketSaleQueue("Marianne");
            twice.AddToTicketSaleQueue("May");
            twice.AddToTicketSaleQueue("Ben");
            twice.AddToTicketSaleQueue("Vanessa");
            twice.AddToTicketSaleQueue("Carlos");
            twice.AddToTicketSaleQueue("Lisa");
            // Programmablauf 2: Simuliere den Ticketkauf und speichere die gekauften Tickets in der Klasse Ticket-Anbieter in einem Dictionary mit dem Personen- und Konzertname.
            System.Console.WriteLine("--------------------------------");
            for (int i = 0; i < 4; i++)
            {
                TicketProvider.TicketHolders.Add(ateez.RemoveFromTicketSale(), "Ateez");
            }
            System.Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                TicketProvider.TicketHolders.Add(taylorSwift.RemoveFromTicketSale(), "Taylor Swift");
            }
            System.Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                TicketProvider.TicketHolders.Add(twice.RemoveFromTicketSale(), "Twice");
            }

            //Gib auf der Console aus, welche Person auf welches Konzert geht.
            TicketProvider.DisplayTicketHolders();
        }
    }
}