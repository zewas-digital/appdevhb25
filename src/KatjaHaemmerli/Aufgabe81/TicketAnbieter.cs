using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe81
{
    public class TicketAnbieter
    {
        public Dictionary<string, string> PersonenUndKonzerte;

        public TicketAnbieter()
        {
            PersonenUndKonzerte = new Dictionary<string, string>();
        }

        public void AusgabeTicketbesitzerUndKonzerte()
        {
            foreach(KeyValuePair<string, string> item in PersonenUndKonzerte)
            {
                System.Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}