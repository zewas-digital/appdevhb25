using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace Appdevhb25.NoahHois.Aufgabe66
{
    public class Person
    {
        public int Height;
        public DateTime Birthday;
        public string Name;
        public int Weight;


        public Person(int height, DateTime birthday, string name, int weight)
        {
            Height = height;
            Birthday = birthday;
            Name = name;
            Weight = weight;
        }



        public void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Größe: " + Height);
            Console.WriteLine("Gewicht: " + Weight);
            Console.WriteLine("Geburtstag: " + Birthday.ToString("d"));
        }
        public void GetBirthday()
        {
            TimeSpan timeSpan = DateTime.Now - Birthday;
            int age = timeSpan.Days / 365;
            Console.WriteLine($"{Name} ist {age} Jahre alt");
        }
    }
}