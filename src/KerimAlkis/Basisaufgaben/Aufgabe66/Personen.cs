namespace Appdevhb25.KerimAlkis.Aufgabe66
{
    public class Personen
    {
        public static void Start()
        {
            Person p1 = new Person(175, new DateTime(2006, 04, 12), "Kerim", 76);
            Person p2 = new Person(160, new DateTime(2007, 07, 01), "Hans", 80);
            Person p3 = new Person(190, new DateTime(2002, 10, 10), "Peter", 90);

            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            people.Add(p3);

            foreach(Person p in people)
            {
                p.Print();
                p.GetBirthday();
                System.Console.WriteLine();
            }
        }
    }

    public class Person
    {
        public double Groesse;
        public DateTime GeburtsDatum;
        public string Name;
        public double Gewicht;

        public Person(double groesse, DateTime geburtsDatum, string name, double gewicht)
        {
            this.Groesse = groesse;
            this.GeburtsDatum = geburtsDatum;
            this.Name = name;
            this.Gewicht = gewicht;
        }

        public void Print()
        {
            System.Console.WriteLine($"{Name} ist {Groesse} cm gross und {Gewicht} kg schwer. Geburtsdatum: {GeburtsDatum.ToString("dd.MM.yyyy")}");
        }
        public void GetBirthday()
        {
            int tage = (DateTime.Now - GeburtsDatum).Days;
            int alter = tage/365;
            System.Console.WriteLine($"{Name}'s Alter ist {alter} Jahre alt");
        }


    }
}