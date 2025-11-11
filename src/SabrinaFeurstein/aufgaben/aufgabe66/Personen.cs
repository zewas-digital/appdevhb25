namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe66
{
    public class Personen
    {
        public static void Start()
        {
            Person[] personen =
            [
                new Person(1.63, new DateTime(2005, 05, 24), "Julia", 45),
                new Person(1.80, new DateTime(1996, 11, 07), "John", 55.6),
                new Person(1.77, new DateTime(1999, 08, 13), "Judy", 53.67),
            ];

            foreach (Person person in personen)
            {
                person.GetBirthday();
                person.Print();
            }
        }
    }
}