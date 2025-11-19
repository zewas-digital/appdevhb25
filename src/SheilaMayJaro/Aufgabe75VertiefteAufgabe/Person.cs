using System.Diagnostics.Contracts;

namespace Appdevhb25.SheilaMayJaro.Aufgabe75VertiefteAufgabe
{
    public class Person
    {
        private double _height; 
        private string? _name;
        private int _age;
        private double _weight;
        public double Height
        {
            get
            {
                return _height; 
            }
            set
            {
                _height = value; 
            }
        }
        public int Age
        {
            get
            {
                return _age; 
            }
            set
            {
                _age = value; 
            }
        }
        // public string? Name{ get; set; }
        public double Weight
        {
            get
            {
                return _weight; 
            }
            private set
            {
                _weight = value; 
            }
        }
        
        public string? Name
        {
            get
            {

                return _name;
            }
            set
            {

                _name = value;
            }
        }
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

        //Exkurs mit Mischa zu Setter und Getter
        // public bool IsHeavy()
        // {

        //     var p = new Person()
        //     {
        //         Weight = 5.6
        //     };

        //     return true;
        // }

    }
}