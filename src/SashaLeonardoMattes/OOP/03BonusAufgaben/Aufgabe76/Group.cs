using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe76
{

    public class Group
    {

        public List<Person> persons = new List<Person>();

        public void AddPerson(Person p)
        {
            persons.Add(p);
        }

        public string GetBiggest()
        {
            int maxAge = persons.Max(p => p.Age);
            int maxHeight = persons.Max(p => p.Height);
            int maxWheight = persons.Max(p => p.Wheight);

            string maxHeightOutput = "Größte Person(en): " + string.Join(", ", persons.Where(p => p.Height == maxHeight).Select(p => p.Name)) + " mit: " + maxHeight;
            string maxAgeOutput = "Älteste Person(en): " + string.Join(", ", persons.Where(p => p.Age == maxAge).Select(p => p.Name)) + " mit: " + maxAge;
            string maxWheightOutput = "Schwerste Person(en): " + string.Join(", ", persons.Where(p => p.Wheight == maxWheight).Select(p => p.Name)) + " mit: " + maxWheight;

            return maxHeightOutput + "\n" + maxAgeOutput + "\n" + maxWheightOutput;
        }

        public string GetSmallest()
        {
            int minAge = persons.Min(p => p.Age);
            int minHeight = persons.Min(p => p.Height);
            int minWheight = persons.Min(p => p.Wheight);

            string minHeightOutput = "Kleinste Person(en): " + string.Join(", ", persons.Where(p => p.Height == minHeight).Select(p => p.Name)) + " mit: " +minHeight;
            string minAgeOutput = "Jüngste Person(en): " + string.Join(", ", persons.Where(p => p.Age == minAge).Select(p => p.Name)) + " mit: " + minAge;
            string minWheightOutput = "Leichteste Person(en): " + string.Join(", ", persons.Where(p => p.Wheight == minWheight).Select(p => p.Name)) + " mit: " + minWheight;

            return minHeightOutput + "\n" + minAgeOutput + "\n" + minWheightOutput;
        }

        public string GetAverage()
        {
            double averageAge = persons.Average(p => p.Age);
            double averageHeight = persons.Average(p => p.Height);
            double aveageWheight = persons.Average(p => p.Wheight);

            return $"Durchschnittsalter: {averageAge}\n DurchschnittsGröße: {averageHeight}\n Durchchnittsgewicht: {aveageWheight}";
        }

        public List<Person> SortByAge(bool sortAsc)
        {
            if (sortAsc)
            {
                return persons.OrderBy(p => p.Age).ToList();
            }
            else
            {
                return persons.OrderByDescending(p => p.Age).ToList();
            }
        }

        public List<Person> SortByHeight(bool sortAsc)
        {
            if (sortAsc)
            {
                return persons.OrderBy(p => p.Height).ToList();
            }
            else
            {
                return persons.OrderByDescending(p => p.Height).ToList();
            }
        }

        public List<Person> SortByWheight(bool sortAsc)
        {
            if (sortAsc)
            {
                return persons.OrderBy(p => p.Wheight).ToList();
            }
            else
            {
                return persons.OrderByDescending(p => p.Wheight).ToList();
            }
        }

        public List<Person> SortByName(bool sortAsc)
        {
            if (sortAsc)
            {
                return persons.OrderBy(p => p.Name).ToList();
            }
            else
            {
                return persons.OrderByDescending(p => p.Name).ToList();
            }
        }

        public Person FindPerson(string name)
        {

            Person? p = persons.Find(p => p.Name == name);
            if (p == null)
            {
                p = new Person();
                p.Name = "NOT FOUND!";
            }
            return p;
        }

        public void RemovePerson(string ssn)
        {
            Person? p = persons.Find(p => p.socialSecurityNumber == ssn);
            if (p != null)
            {
                persons.Remove(p);
            }
        }

        public static void PrintGroop(List<Person> personList)
        {
            System.Console.WriteLine("Gruppe:");
            foreach (var item in personList)
            {
                System.Console.WriteLine(item.Name + " ");
            }
            System.Console.WriteLine();
        }
    }
}