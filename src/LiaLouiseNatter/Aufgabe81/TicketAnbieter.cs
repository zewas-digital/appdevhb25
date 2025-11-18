namespace Appdevhb25.LiaLouiseNatter.Aufgabe81
{
    public class TicketAnbieter
    {
     
        private Dictionary<Queue<string>,string> ConcertsAndCustomers = new Dictionary<Queue<string>, string>();
          public void Concerts()
        {
            System.Console.WriteLine("=============Concerts Today=============");
            System.Console.WriteLine("Yung Hurn");
            System.Console.WriteLine("Luckie");
            System.Console.WriteLine("Masi");
            System.Console.WriteLine("Cro");
            
        }
        public void ChosenConcert(string chosenConcert, Queue<string> name)
        {
            ConcertsAndCustomers.Add(name, chosenConcert);
        }

        public void TicketPrinter()
        {
            foreach(KeyValuePair<Queue<string>, string> werte in ConcertsAndCustomers)
            {
                foreach(string person in werte.Key)
                {
                    System.Console.WriteLine($"Person: {person} Concert: {werte.Value}");
                }
            }
        }


    }
}