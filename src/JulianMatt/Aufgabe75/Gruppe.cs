using System.Globalization;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Aufgabe75
{
    public class Gruppe
    {
        public List<Person> Personen { get; private set; }

        public Gruppe()
        {
            Personen = new List<Person>();
        }
        public void AddPerson(int i)
        {
            Console.WriteLine("Wie heißt die Person die Sie zufügen wollen? ");
            string name = Console.ReadLine();

            Console.WriteLine("Wie alt ist die Person? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wie groß ist die Person? ");
            double hight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie viel wiegt die Person? ");
            double wieght = Convert.ToDouble(Console.ReadLine());

            Personen.Add(new Person(name, age, hight, wieght));
            Console.Clear();
        }

        public void PrintGroup(int i)
        {
            Console.WriteLine($"Name: {Personen[0].Name}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Alter: {Personen[0].Age}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Größe: {Personen[0].Hight}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Gewicht: {Personen[0].Wieght}");
        }

        public double Smallest(string Field)
        {
            return Convert.ToDouble(Personen.Min(p => p.GetType().GetProperty(Field).GetValue(p, null)));
        }

        public double BiggestElement(string Field)
        {
            return Convert.ToDouble(Personen.Max(person => person.GetType().GetProperty(Field).GetValue(person, null)));
        }

        public double Avg(string Field)
        {
            return Convert.ToDouble(Personen.Average(person => Convert.ToDouble(person.GetType().GetProperty(Field).GetValue(person, null))));
        }
    }
}