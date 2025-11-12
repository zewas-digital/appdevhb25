using System.Numerics;

namespace Appdevhb25.SheilaMayJaro.Aufgabe75VertiefteAufgabe
{
    public class Group
    {
        List<Person> people = new List<Person>();
        public List<Person> Addperson(Person person)
        {
            people.Add(person);
            return people;
        }
        public Person SmallestPerson()
        {   
            return people.MinBy(person => person.Height);
        }
        public Person TallestPerson()
        {

            return people.MaxBy(person => person.Height);
        }
        public double AverageHeight()
        {

            return people.Average(person => person.Height);
        }
        public Person YoungestPerson()
        {
            return people.MinBy(person => person.Age);
        }
        public Person OldestPerson()
        {

            return people.MaxBy(person => person.Age);
        }
        public double AverageAge()
        {
            return people.Average(person => person.Age);
        }
        public Person LightestWeight()
        {
            return people.MinBy(person => person.Weight);
        }
        public Person HeaviestWeight()
        {

            return people.MaxBy(person => person.Weight);
        }
        public double AverageWeight()
        {
            return people.Average(person => person.Weight);
        }
    }
}