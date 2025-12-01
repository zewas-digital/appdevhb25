namespace Appdevhb25.SheilaMayJaro.Aufgabe96
{
    public abstract class Shape
    {
        public string? Name { get; protected set; }
        public string? Elementtype { get; protected set; }
        public Shape(string name)
        {
            Name = name;
        }
        public abstract double CalculateArea(); 
        public abstract double CalculatePerimeter();
        public override string ToString()
        {
            return $"\nName: {Name}\nElementtyp: {Elementtype}"; 
        }
    }
}