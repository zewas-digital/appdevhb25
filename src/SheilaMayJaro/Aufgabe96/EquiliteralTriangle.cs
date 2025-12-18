namespace Appdevhb25.SheilaMayJaro.Aufgabe96
{
    public class EquiliteralTriangle : Shape
    {
        private double _length = 1;
        public double Length
        {
            get { return _length; }
            private set
            {
                if (value > 0)
                {
                    _length = value;
                }
            }
        }
        private static int EquiliteralTriangleCreated { get; set; }
        public EquiliteralTriangle(double length, string name) : base(name)
        {
            Length = length;
            EquiliteralTriangleCreated++;
        }
        public override double CalculateArea()
        {
            return Length * Length * (Math.Sqrt(3) / 4);
        }
        public override double CalculatePerimeter()
        {
            return Length * 3;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nLänge: {Length,40:N2}\nUmfang: {CalculatePerimeter(),39:N2} \nFlächeninhalt: {CalculateArea(),32:N2}\n{new string('-', 50)}";
        }
        public static string DisplayNumberOfTriangles()
        {
            if (EquiliteralTriangleCreated == 1)
            {
                return $"Es ist 1 gleichseitiges Dreieck erstellt worden."; 
            }
            else
            {
                return $"Es sind {EquiliteralTriangleCreated} gleichseitige Dreiecke erstellt worden.";
            }
        }
    }
}