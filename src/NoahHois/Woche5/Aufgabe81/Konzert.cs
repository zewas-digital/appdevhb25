using System.Collections;
using System.Xml.Serialization;

namespace Appdevhb25.NoahHois.Aufgabe81
{
    public class Concert
    {
        public string Concerts;
        public Queue<string> queue = new();
        public Concert(string concerts)
        {
            Concerts = concerts;
        }
        public void PeopleInQueue(string persons)
        {
            queue.Enqueue(persons);
        }
    }
}