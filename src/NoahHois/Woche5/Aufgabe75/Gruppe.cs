using System.Collections.Generic;

namespace Appdevhb25.NoahHois.Aufgabe75
{
    public class Gruppe
    {
        private List<Person> people = new List<Person>();
        public void PersonList(Person person)
        {
            people.Add(person);
        }
        public double CalculateTheSmallest()
        {
            double minHeight = people[0].Height;
            foreach (Person p in people)
            {
                if (p.Height <= minHeight)
                {
                    minHeight = p.Height;
                }
            }

            return minHeight;
        }
        public double CalculateTheBiggest()
        {
            double maxHeight = people[0].Height;
            foreach (Person p in people)
            {
                if (p.Height >= maxHeight)
                {
                    maxHeight = p.Height;
                }
            }
            return maxHeight;
        }
        public double CalculateAverage()
        {
            double averageHeight = 0;
            foreach (Person p in people)
            {
                averageHeight += p.Height;
            }
            averageHeight /= people.Count;
            return averageHeight;
        }
    }
}