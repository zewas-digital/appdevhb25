using Appdevhb25.SheilaMayJaro.Aufgabe75VertiefteAufgabe;

namespace Appdevhb25.SheilaMayJaro.Aufgabe76Bonus
{
    public class Aufgabe76
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 76)");

            Person person0 = new Person(1.80, 20, "Didi", 53);
            Person person1 = new Person(1.59, 14, "Bertram", 55);
            Person person2 = new Person(1.68, 52, "Emilia", 87);
            Person person3 = new Person(1.74, 25, "Arnold", 75.8);
            Person person4 = new Person(1.62, 31, "Claude", 61);
            Person person5 = new Person(1.71, 42, "Claude", 65);
            person0.SocialSecurityNumber = 1234; 
            person1.SocialSecurityNumber = 4321;
            person2.SocialSecurityNumber = 9876; 
            person3.SocialSecurityNumber = 6789;
            person4.SocialSecurityNumber = 2345;
            person5.SocialSecurityNumber = 5432;

            Group people = new Group();
            people.Addperson(person0);
            people.Addperson(person1);
            people.Addperson(person2);
            people.Addperson(person3);
            people.Addperson(person4);
            people.Addperson(person5); 
            people.DisplayGroup();

            System.Console.WriteLine("\nSortiert nach Name:");
            foreach (Person person in  people.SortByName())
            {
                Console.WriteLine(person.DisplayPerson());
            }
            System.Console.WriteLine("\nSortiert nach Alter:");
            foreach (Person person in  people.SortByAge())
            {
                Console.WriteLine(person.DisplayPerson());
            }
            System.Console.WriteLine("\nSortiert nach Größe:");
             foreach (Person person in  people.SortByHeight())
            {
                Console.WriteLine(person.DisplayPerson());
            }
            System.Console.WriteLine("\nSortiert nach Gewicht:");
            foreach (Person person in people.SortByWeight())
            {
                Console.WriteLine(person.DisplayPerson());
            }
            Console.WriteLine(people.FindPerson().DisplayPerson()); 
            foreach (Person person in people.FindAllPersons())
            {
                Console.WriteLine(person.DisplayPerson());
            }
            people.RemoveBySocialSecurityNumber(); 

            people.DisplayGroup(); 
        }
    }
}