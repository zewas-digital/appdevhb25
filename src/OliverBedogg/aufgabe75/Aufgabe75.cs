using System;

namespace Appdevhb25.OliverBedogg.aufgabe75
{
    public class Aufgabe75
    {

        public static void Start()
        {
            Gruppe gruppe = new Gruppe();
            gruppe.plusPerson(new Person("Max", 25, 1.80, 75.0));
            gruppe.plusPerson(new Person("Erika", 30, 1.65, 60.0));
            gruppe.plusPerson(new Person("Tom", 16, 1.82, 80.0));
            gruppe.plusPerson(new Person("Leon", 18, 1.75, 68.0));
            gruppe.plusPerson(new Person("Anna", 22, 1.70, 55.0));
            
            Console.WriteLine(gruppe);
            Console.WriteLine("Durchschnittsalter: " + gruppe.durchschnittsalter());
            Console.WriteLine("Größte Person: " + gruppe.groesstePerson() + " m");
            Console.WriteLine("----");
            Console.WriteLine("Kleinster Wert (Alter): " + gruppe.kleinsterWert("Alter"));
        }


    }
}