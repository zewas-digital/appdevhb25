using System.Xml.Serialization;

namespace Appdevhb25.NoahHois.Aufgabe81
{
    public class ProgramTicketsystem
    {
        public static void Start()
        {
            ProgramTicketsystem pts = new ProgramTicketsystem();

            Concert firstConcert = new("Cro");
            Concert secondConcert = new("Yuno Miles");
            Concert thirdConcert = new("Makko");
            Concert fourthConcert = new("Peter Fox");
            firstConcert.PeopleInQueue("Rainer Winkler");
            secondConcert.PeopleInQueue("Benjamin Hauser");
            thirdConcert.PeopleInQueue("Lara Hois");
            fourthConcert.PeopleInQueue("Kevin Teller");
            fourthConcert.PeopleInQueue("Paul Haumner");
            secondConcert.PeopleInQueue("Nicolas Lazeriedes");
            firstConcert.PeopleInQueue("Lion Hämmerle");
            thirdConcert.PeopleInQueue("Marc Gebauer");
        }
    }
}