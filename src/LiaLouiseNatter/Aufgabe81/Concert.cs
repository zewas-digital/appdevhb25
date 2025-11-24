namespace Appdevhb25.LiaLouiseNatter.Aufgabe81
{
    public class Concert
    {
        public static void Start()
        {
            Konzert k1 = new Konzert();
            k1.QueueUp("Sasha");
            k1.QueueUp("Sashaa" );
            k1.QueueUp("Sashab" );
            k1.QueueUp("Sashac");
            TicketAnbieter t1 = new TicketAnbieter();
            t1.ChosenConcert("Cro", k1.waitingQueue);

            Konzert k2= new Konzert();
            k2.QueueUp("Sashaa");
            k2.QueueUp("Sashaaa" );
            k2.QueueUp("Sashabb" );
            k2.QueueUp("Sashacc");
            TicketAnbieter t2 = new TicketAnbieter();
            t2.ChosenConcert("Masi", k1.waitingQueue);

            t1.TicketPrinter();
            t2.TicketPrinter();


        }
    }
}