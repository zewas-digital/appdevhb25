namespace Appdevhb25.SheilaMayJaro.Aufgabe81
{
    public class TicketProvider
    {
        //Programmablauf 2: Simuliere den Ticketkauf und speichere die gekauften Tickets in der Klasse Ticket-Anbieter in einem Dictionary mit dem Personen- und Konzertname.
        public static Dictionary<string, string> TicketHolders = new Dictionary<string, string>(); 

        public static void DisplayTicketHolders()
        {
            foreach (var item in TicketHolders)
            {
                System.Console.WriteLine($"{item.Key} geht auf das Konzert von {item.Value}.");
            }
        }
        
    }
}