namespace Appdevhb25.JonaSchnell.Aufgabe96
{
    public class Triangle : Figure
    {
        public double A { get; set; }
        public Triangle(string name, double a) : base(name, "Triangle")
        {
            A = a;
        }
        public override double CalculateCircumference()
        {
            return Math.Sqrt(3) / 4 * (A * A);
        }
        public override double CalculateArea()
        {
            return A * 3;
        }
    }
}