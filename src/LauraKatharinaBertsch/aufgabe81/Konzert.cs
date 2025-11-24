namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe81
{
    public class Konzert
    {
        public Queue<string> queue;
        public string ConcertName;

        public Konzert(string concertName)
        {
            queue = new Queue<string>();
            ConcertName = concertName;
        }
    }
}