namespace Appdevhb25.SheilaMayJaro.Aufgabe96
{
    public class Circle : Shape, IScalable
    {
        public double Radius {get; private set;} = 1;
        private static int CircleCreated {get; set; }
        public Circle(int radius, string name) : base(name)
        {
            if (radius > 0)
            {
                Radius = radius;
            }
            CircleCreated++;
        }
        public override double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nRadius: {Radius, 39:N2}\nUmfang: {CalculatePerimeter(), 39:N2} \nFlächeninhalt: {CalculateArea(), 32:N2}\n{new string('-', 50)}";
        }
        public void Scaling(double factor)
        {
            if (factor > 0)
            {
               Radius *= factor; 
            }
        }
        public static string DisplayNumberOfCircles()
        {
            if (CircleCreated == 1)
            {
                return $"Es ist 1 Kreis erstellt worden.";
            }
            else
            {
                return $"Es sind {CircleCreated} Kreise erstellt worden.";
            }
        }
    }
}