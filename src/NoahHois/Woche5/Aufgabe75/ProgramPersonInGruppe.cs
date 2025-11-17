namespace Appdevhb25.NoahHois.Aufgabe75
{
    public class ProgramPersonInGruppe
    {
        public static void Start()
        {
            Person[] people = new Person[5];
            Person firstPerson = new Person(175, 16, "Aaron", 65.4);
            Person secondPerson = new Person(192.6, 21, "Herbert", 78.9);
            Person thirdPerson = new Person(167.4, 17, "Lisa", 57.3);
            Person fourthPerson = new Person(154.7, 14, "Lara", 59.1);
            Person fifthPerson = new Person(183.3, 18, "Jakob", 68.8);
            people[0] = firstPerson;
            people[1] = secondPerson;
            people[2] = thirdPerson;
            people[3] = fourthPerson;
            people[4] = fifthPerson;
            Gruppe gruppe = new Gruppe();
            foreach (Person p in people)
            {
                gruppe.PersonList(p);
            }
            gruppe.CalculateTheSmallest();
            gruppe.CalculateTheBiggest();
            gruppe.CalculateAverage();
            System.Console.WriteLine("Min " + gruppe.CalculateTheSmallest());
            System.Console.WriteLine("Max " + gruppe.CalculateTheBiggest());
            System.Console.WriteLine("Average " + gruppe.CalculateAverage());
        }
    }
}