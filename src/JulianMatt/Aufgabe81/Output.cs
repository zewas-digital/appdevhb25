using Appdevhb25.JulianMatt.Aufgabe81;

namespace Appdevhb25.JulianMatt.Aufgabe81
{
    public class Output
    {
        public static void Start81()
        {
            TicketAnbieter Tickets = new TicketAnbieter();

            Tickets.FillTicketsUp();

            Tickets.QueuePeopleOut();

            Tickets.PrintOutPeopleWhoGotATicket();
        }
    }
}