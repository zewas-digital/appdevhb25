namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe75
{
    public class Person
    {
        public string Name;
        public int Alter;
        public double Groesse;
        public double Gewicht;

        public Person(string name, int alter, double groesse, double gewicht)
        {
            Name = name;
            Alter = alter;
            Groesse = groesse;
            Gewicht = gewicht;
        }

        public override string ToString()
        {
            return $"{Name} ({Alter}) - {Groesse:F2} m - {Gewicht} kg";
        }
    }
}