using System.Security;

namespace Appdevhb25.JulianMatt.Aufgabe81
{
    public class Konzerte
    {
        public Queue<string> Queue = new Queue<string>();
        public string ConcertName;

        public Konzerte(string concertName)
        {
            ConcertName = concertName;
        }
    }
}