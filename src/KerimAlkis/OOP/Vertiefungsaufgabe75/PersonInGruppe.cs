using Appdevhb25.KerimAlkis.Aufgabe04;

namespace Appdevhb25.KerimAlkis.Vertiefungsaufgabe75
{
    public class PersonInGruppe
    {
        public static void Start()
        {
            Gruppe mainGruppe = new Gruppe();
            mainGruppe.PersonHinzufuegen(new Person(165, 22, "Mari", 60));
            mainGruppe.PersonHinzufuegen(new Person(180, 25, "Hans", 82));
            mainGruppe.PersonHinzufuegen(new Person(160, 19, "Laura", 55));
            mainGruppe.PersonHinzufuegen(new Person(175, 23, "Ben", 70));


            System.Console.WriteLine(mainGruppe.DatenAlter());
            System.Console.WriteLine();
            System.Console.WriteLine(mainGruppe.DatenGewicht());
            System.Console.WriteLine();
            System.Console.WriteLine(mainGruppe.DatenGroesse());
        }
    }
    public class Person
    {
        public double Groesse;
        public int Alter;
        public string Name;
        public double Gewicht;

        public Person(double groesse, int alter, string name, double gewicht)
        {
            Groesse = groesse;
            Alter = alter;
            Name = name;
            Gewicht = gewicht;
        }

    }
    public class Gruppe
    {
        private List<Person> PersonenGruppe;
        public Gruppe()
        {
            PersonenGruppe = new List<Person>();
        }
        public void PersonHinzufuegen(Person HinzuPers)
        {
            PersonenGruppe.Add(HinzuPers);
        }
        public string DatenGroesse()
        {
            return $"Daten Groesse:\nMin-> {PersonenGruppe.Min(p => p.Groesse)}cm\nMax-> {PersonenGruppe.Max(p => p.Groesse)}cm\nAverage-> {PersonenGruppe.Average(p => p.Groesse)}cm";
        }
        public string DatenAlter()
        {
            return $"Daten Alter:\nMin-> {PersonenGruppe.Min(p => p.Alter)}\nMax-> {PersonenGruppe.Max(p => p.Alter)}\nAverage-> {PersonenGruppe.Average(p => p.Alter)}";
        }
        public string DatenGewicht()
        {
            return $"Daten Gewicht:\nMin-> {PersonenGruppe.Min(p => p.Gewicht)}kg\nMax-> {PersonenGruppe.Max(p => p.Gewicht)}kg\nAverage-> {PersonenGruppe.Average(p => p.Gewicht)}kg";
        }
    }
}