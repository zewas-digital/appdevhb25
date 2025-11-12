using Appdevhb25.LauraKatharinaBertsch.Aufgabe74;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe76
{
    public class Gruppe
    {
        public static List<Person> gruppe = new List<Person>();

        public static void AddPerson(Person person)
        {
            gruppe.Add(person);
        }
        public static List<Person> SortedHight(bool parameter = true)
        {
            List<Person> sortedHight = new List<Person>(gruppe);

            if (parameter == false)
            {
                sortedHight.Sort((p1, p2) => p1.Groesse.CompareTo(p2.Groesse));
            }
            else
            {
                sortedHight.Sort((p1, p2) => p1.Groesse.CompareTo(p2.Groesse));
                sortedHight.Reverse();
            }
            return sortedHight;
        }
        public static List<Person> SortedAge(bool parameter = true)
        {
            List<Person> sortedAge = new List<Person>(gruppe);
            if (parameter)
            {
                sortedAge.Sort((p1, p2) => p1.Alter.CompareTo(p2.Alter));
            }
            else
            {
                sortedAge.Sort((p1, p2) => p1.Alter.CompareTo(p2.Alter));
                sortedAge.Reverse();
            }
            return sortedAge;
        }
        public static List<Person> SortedWeight(bool parameter = true)
        {
            List<Person> sortedWeight = new List<Person>(gruppe);
            if (parameter)
            {
                sortedWeight.Sort((p1, p2) => p1.Gewicht.CompareTo(p2.Gewicht));
            }
            else
            {
                sortedWeight.Sort((p1, p2) => p1.Gewicht.CompareTo(p2.Gewicht));
                sortedWeight.Reverse();
            }
            return sortedWeight;
        }
        public static List<Person> SortedName(bool parameter = true)
        {
            List<Person> sortedName = new List<Person>(gruppe);
            if (parameter)
            {
                sortedName.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            }
            else
            {
                sortedName.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
                sortedName.Reverse();
            }
            return sortedName;
        }
        public Person FindePerson(Predicate<Person> match)
        {
            return gruppe.Find(match);
        }
        public List<Person> FindeAllePersonen(Predicate<Person> match)
        {
            return gruppe.FindAll(match);
        }
    }
}