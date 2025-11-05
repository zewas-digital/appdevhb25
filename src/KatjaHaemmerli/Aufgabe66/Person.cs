
namespace Appdevhb25.KatjaHaemmerli.Aufgab66
{
    public class Person
    {
        public string Name;
        public DateTime Geburtstag;
        public double Groesse;
        public int Gewicht;

        public Person() // 1. Konstruktor 
        {

        }
        // es kann mehrere Konstruktoren geben, 
        // wenn sie sich in der Anzahl der Parameter und/oder der Datentypen unterscheiden
        public Person(string name, double groesse) // 2. Konstruktor // Ich erzwinge, dass alle Attribute beim Aufruf des Konstruktors definiert werden müssen            
        {
            Name = name;
            Groesse = groesse;
        }
        public void PrintPersonenAttribute()
        {
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Geburtstag: {Geburtstag:yyyy.MM.dd}");
            System.Console.WriteLine($"Grösse: {Groesse}");
            System.Console.WriteLine($"Gewicht: {Gewicht}");
        }

        public void AlterBerechnen()
        {
            DateTime today = DateTime.Now;

            // DateTime - DateTime = TimeSpan (Zeitspanne: Zeit zwischen zwei Daten)
            int alter = today.Year - Geburtstag.Year;

            System.Console.WriteLine($"Alter: {alter}");
        }
    }
}