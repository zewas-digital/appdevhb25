namespace Appdevhb25.SheilaMayJaro.Aufgabe96
{
    public abstract class Shape
    {
        public string? Name { get; protected set; }
        public Shape(string name)
        {
            Name = name;
        }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public override string ToString()
        {
            return $"""
            {new string('-', 50)}
            Name: {Name, 41}
            Elementtyp: {GetType().Name, 35}
            """;
            // return   $"\nName: {Name}\nElementtyp: {Elementtype}";
        }
    }
}