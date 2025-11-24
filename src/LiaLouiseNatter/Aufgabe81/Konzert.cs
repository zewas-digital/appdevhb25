namespace Appdevhb25.LiaLouiseNatter.Aufgabe81
{
    public class Konzert
    {
        public Queue<string> waitingQueue = new Queue<string>();
        public void QueueUp(string name)
        {
            waitingQueue.Enqueue(name); 
        }


    }
}