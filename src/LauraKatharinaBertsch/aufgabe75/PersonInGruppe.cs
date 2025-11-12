namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe75
{
    public class PersonInGruppe
    {
        public static void Start()
        {
            Gruppe.AddPerson(new Person(1.23m, 15, "Anton", 34.2m));
            Gruppe.AddPerson(new Person(1.17m, 13, "Peter", 55.3m));
            Gruppe.AddPerson(new Person(1.52m, 20, "Luise", 54.9m));
            Gruppe.AddPerson(new Person(1.79m, 19, "Felix", 43.1m));
            Gruppe.AddPerson(new Person(1.34m, 14, "Marie", 36.5m));


            decimal smallest = Gruppe.SmallestPerson();
            decimal biggest = Gruppe.BiggestPerson();
            int youngest = Gruppe.YoungestPerson();
            int oldest = Gruppe.OldestPerson();
            decimal lightest = Gruppe.LightestPerson();
            decimal heaviest = Gruppe.HeaviestPerson();
            decimal size = Gruppe.AverageSize();
            int age = Gruppe.AverageAge();
            decimal weight = Gruppe.AverageWeight();

            Console.WriteLine("Die kleinste Person ist " + smallest + "m groß");
            Console.WriteLine("Die größte Person ist " + biggest + "m groß");
            Console.WriteLine("Die jünste Person ist " + youngest + " Jahre alt");
            Console.WriteLine("Die älteste Person ist " + oldest + " Jahre alt");
            Console.WriteLine("Die leichteste Person wiegt " + lightest + "kg");
            Console.WriteLine("Die schwerste Person wiegt " + heaviest + "kg");
            Console.WriteLine("Die Personen sind durchschnittlich " + size + "m groß");
            Console.WriteLine("Die Personen sind durchschnittlich " + age + " Jahre alt");
            Console.WriteLine("Die Personen sind durchschnittlich " + weight + "kg schwer");
        }
    }
}