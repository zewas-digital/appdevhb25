using System.Globalization;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Aufgabe76
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

            System.Console.WriteLine("Wie lautet die Sozialversicherungsnummer");
            string socialNumber = Console.ReadLine();

            Personen.Add(new Person(name, age, hight, wieght, socialNumber));
            Console.Clear();
        }

        public void PrintGroup()
        {
            Console.WriteLine($"Name: {Personen[0].Name}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Alter: {Personen[0].Age}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Größe: {Personen[0].Hight}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Gewicht: {Personen[0].Wieght}");
            Console.WriteLine("----------------------------");
            System.Console.WriteLine($"Sozialversichrungsnummer: {Personen[0].SocialNumber}");
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

        public void SortByField(string Field, List<Gruppe> groups)
        {
            for (int i = 0; i < groups.Count - 1; i++)
            {
                for (int j = 0; j < groups.Count - i - 1; j++)
                {
                    double currentHight = Convert.ToDouble(groups[j].Personen[0].GetType().GetProperty(Field).GetValue(groups[j].Personen[0], null));
                    double nextHight = Convert.ToDouble(groups[j + 1].Personen[0].GetType().GetProperty(Field).GetValue(groups[j + 1].Personen[0], null));

                    if (currentHight > nextHight)
                    {
                        Gruppe temp = groups[j];
                        groups[j] = groups[j + 1];
                        groups[j + 1] = temp;
                    }
                }
            }
        }

        public void SortByFieldString(string Field)
        {
            Personen.Sort((a, b) => b.Name.CompareTo(a.Name));
        }

        public bool FindPerson(string person)
        {
            if (person.ToLower() == Personen[0].Name.ToLower())
            {
                System.Console.WriteLine();
                PrintGroup();
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool DeletePerson (string socialNumber)
        {
            if (socialNumber == Personen[0].SocialNumber)
            {
                System.Console.WriteLine();
                Personen.RemoveAt(0);
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }
}