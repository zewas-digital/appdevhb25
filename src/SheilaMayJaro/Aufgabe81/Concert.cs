namespace Appdevhb25.SheilaMayJaro.Aufgabe81
{
    public class Concert
    {
        Queue<string> concertLine = new Queue<string>(); //Warteschlange an der Kasse

        public void AddToTicketSaleQueue(string name)
        {
            concertLine.Enqueue(name); 
        }
        public string RemoveFromTicketSale()
        {
            return concertLine.Dequeue(); 
        }
    }
}