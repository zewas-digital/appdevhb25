namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe66
{
    public class Person
    {
        public double Groesse;
        public DateTime Geburtstag;
        public string Name;
        public double Gewicht;
        public int Alter;

        public Person(double groesse, DateTime geburtstag, string name, double gewicht)
        {
            Groesse = groesse;
            Geburtstag = geburtstag;
            Name = name;
            Gewicht = gewicht;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} ({Alter}): {Geburtstag:d} - {Groesse:F2} m - {Gewicht:F2} kg");
        }

        public void GetBirthday()
        {
            Alter = DateTime.Now.Year - Geburtstag.Year;
            if (Geburtstag.AddYears(Alter) > DateTime.Now)
                Alter--;
        }
    }
}