namespace Appdevhb25.SheilaMayJaro.Aufgabe76Bonus
{
    public class Person
    {
        //Fields
        private double _height;
        private int _age;
        private string? _name;
        private int _socialSecurityNumber;

        private double _weight;
        //Properties oder Gateway
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string? Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public int SocialSecurityNumber
        {
            get{return _socialSecurityNumber;}
            set{_socialSecurityNumber = value;}
        }
        //Konstruktoren
        public Person()
        {

        }
        public Person(double height, int age, string name, double weight)
        {
            _height = height;
            _age = age;
            _name = name;
            _weight = weight;
        }
        public Person(double height, int age)
        {
            Height = height;
            Age = age;
        }
        //Methoden
        public string DisplayPerson()
        {
            return $"\nName: {Name}\nAlter: {Age:D2} Jahre\nGröße: {Height}m\nGewicht: {Weight}kg";
        }
    }
}