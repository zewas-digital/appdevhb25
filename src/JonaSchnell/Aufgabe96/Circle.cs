namespace Appdevhb25.JonaSchnell.Aufgabe96
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(string name, double radius) : base(name, "Circle")
        {
            Radius = radius;
        }
        public override double CalculateCircumference()
        {
            return 2* Math.PI * Radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}