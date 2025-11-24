using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe81
{
    public class StartTicketsystem
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            Concert c1 = new Concert();
            c1.persons.Enqueue("Max1");
            c1.persons.Enqueue("Max2");
            c1.persons.Enqueue("Max3");
            c1.persons.Enqueue("Max4");
            c1.persons.Enqueue("Max5");

            Concert c2 = new Concert();
            c2.persons.Enqueue("Moritz1");
            c2.persons.Enqueue("Moritz2");
            c2.persons.Enqueue("Moritz3");
            c2.persons.Enqueue("Moritz4");
            c2.persons.Enqueue("Moritz5");

            TicketSeller ts1 = new TicketSeller();
            ts1.tickets.Add(c1.persons, "Konzert1");
            ts1.tickets.Add(c2.persons, "Konzert2");

            System.Console.WriteLine("Konzert: " + ts1.tickets[c1.persons]);
            while (c1.persons.Count > 0)
            {
                System.Console.WriteLine(c1.persons.Dequeue());
            }

            System.Console.WriteLine("Konzert: " + ts1.tickets[c2.persons]);
            while (c2.persons.Count > 0)
            {
                System.Console.WriteLine(c2.persons.Dequeue());
            }
        }
    
    }
}
