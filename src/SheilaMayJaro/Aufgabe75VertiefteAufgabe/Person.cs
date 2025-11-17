using System.Diagnostics.Contracts;

namespace Appdevhb25.SheilaMayJaro.Aufgabe75VertiefteAufgabe
{
    public class Person
    {
        public double Height;
        public int Age; 
        public string? Name{ get; set; }
        public double Weight{ get; set; }

        public Person()
        {

        }
        public Person(double height, int age, string name, double weight)
        {
            Height = height;
            Age = age;
            Name = name;
            Weight = weight;
        }
        public Person(double height, int age)
        {
            Height = height;
            Age = age;
        }
    }
}