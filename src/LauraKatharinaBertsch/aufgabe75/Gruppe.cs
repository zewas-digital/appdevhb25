namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe75
{
    public class Gruppe
    {
        public static List<Person> gruppe = new List<Person>();

        public static void AddPerson(Person person)
        {
            gruppe.Add(person);
        }
        public static decimal SmallestPerson()
        {
            decimal smallestPerson = gruppe.Min(p => p.Groesse);
            return smallestPerson;
        }
        public static decimal BiggestPerson()
        {
            decimal biggestPerson = gruppe.Max(p => p.Groesse);
            return biggestPerson;
        }
        public static decimal AverageSize()
        {
            decimal averageSize = gruppe.Sum(p => p.Groesse);
            averageSize = averageSize / gruppe.Count();
            return averageSize;
        }
        public static int YoungestPerson()
        {
            int youngestPerson = gruppe.Min(p => p.Alter);
            return youngestPerson;
        }
        public static int OldestPerson()
        {
            int oldestPerson = gruppe.Max(p => p.Alter);
            return oldestPerson;
        }
        public static int AverageAge()
        {
            int averageAge = gruppe.Sum(p => p.Alter);
            averageAge = averageAge / gruppe.Count();
            return averageAge;
        }
        public static decimal LightestPerson()
        {
            decimal lightestPerson = gruppe.Min(p => p.Gewicht);
            return lightestPerson;
        }
        public static decimal HeaviestPerson()
        {
            decimal heaviestPerson = gruppe.Max(p => p.Gewicht);
            return heaviestPerson;
        }
        public static decimal AverageWeight()
        {
            decimal AverageWeight = gruppe.Sum(p => p.Gewicht);
            AverageWeight = AverageWeight / gruppe.Count();
            return AverageWeight;
        }
    }
}