using System.Numerics;
using Appdevhb25.SheilaMayJaro.Aufgabe76Bonus;

namespace Appdevhb25.SheilaMayJaro.Aufgabe76Bonus
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
        public void DisplayGroup()
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person.DisplayPerson());
            }
        }
        public List<Person> SortByName()
        {
            return people.OrderBy(person => person.Name).ToList();

        }
        public List<Person> SortByHeight()
        {
            return people.OrderBy(person => person.Height).ToList();
        }
        public List<Person> SortByAge()
        {
            return people.OrderBy(person => person.Age).ToList();
        }
        public List<Person>SortByWeight()
        {
            return people.OrderBy(person => person.Weight).ToList();
        }
        public Person FindPerson()
        {
            System.Console.WriteLine("\nGib den Namen der Person ein, die du suchst.");
            string userInput = Console.ReadLine() ?? string.Empty; 
            return people.Find(person => person.Name == userInput);
        }
        public List<Person> FindAllPersons() //Personen mit demselben Namen
        {
            System.Console.WriteLine("\nGib den Namen der Person ein, die du suchst.");
            string? userInput = Console.ReadLine(); 
            return people.FindAll(person => person.Name == userInput);
        }
        public int RemoveBySocialSecurityNumber()
        {
            System.Console.WriteLine("\nGib die Sozialversicherungsnummer der Person ein, die du entfernen willst.");
            string? userInput = Console.ReadLine();
            return people.RemoveAll(person => person.SocialSecurityNumber.ToString() == userInput); 
        }
    }
}