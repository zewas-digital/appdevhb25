namespace Appdevhb25.SheilaMayJaro.Aufgabe75VertiefteAufgabe
{
    public class Aufgabe75
    {
        public static void Start()
        {
            Person person0 = new Person(1.74, 25, "Arnold", 75.8);
            Person person1 = new Person(1.59, 14, "Bertram", 55);
            Person person2 = new Person(1.62, 31, "Claude", 61);
            Person person3 = new Person(1.80, 20, "Didi", 53);
            Person person4 = new Person(1.68, 52, "Emilia", 87);

            Group people = new Group();
            people.Addperson(person0);
            people.Addperson(person1);
            people.Addperson(person2);
            people.Addperson(person3);
            people.Addperson(person4);

            System.Console.WriteLine($"Kleinste Person: {people.SmallestPerson().Name,20} ");
            System.Console.WriteLine($"Größte Person: {people.TallestPerson().Name,20}");
            System.Console.WriteLine($"Durchschnittsgröße: {people.AverageHeight(),20}m");
            System.Console.WriteLine($"Jüngste Person: {people.YoungestPerson().Name,20}");
            System.Console.WriteLine($"Älteste Person: {people.OldestPerson().Name,20}");
            System.Console.WriteLine($"Durchschnittsalter: {people.AverageAge():N0} Jahre");
            System.Console.WriteLine($"Am wenigsten Gewicht hat: {people.LightestWeight().Name,20}");
            System.Console.WriteLine($"Am meisten Gewicht hat: {people.HeaviestWeight().Name,20} ");
            System.Console.WriteLine($"Durchschnittsgewicht: {people.AverageWeight(),20}");
        }
    }
}