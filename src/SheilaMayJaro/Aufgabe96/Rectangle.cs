using System.Reflection.Metadata.Ecma335;

namespace Appdevhb25.SheilaMayJaro.Aufgabe96
{
    public class Rectangle : Shape, IScalable
    {
        public double Length { get; private set; } = 1;
        public double Width { get; private set; } = 1;
        private static int RectangleCreated { get; set; }
        public Rectangle(int width, int length, string name) : base(name)
        {
            if (width > 0)
            {
                Width = width;
            }
            if (length > 0)
            {
                Length = length;
            }
            RectangleCreated++;
        }
        public override double CalculateArea()
        {
            return Width * Length;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Width + Length);
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nLänge: {Length,40:N2}\nBreite: {Width,39:N2}\nUmfang: {CalculatePerimeter(),39:N2} \nFlächeninhalt: {CalculateArea(),32:N2}\n{new string('-', 50)}";
        }
        public void Scaling(double factor)
        {
            if (factor > 0)
            {
                Width *= factor;
                Length *= factor;
            }
        }
        public static string DisplayNumberOfRectangles()
        {
            if (RectangleCreated == 1)
            {
                return $"Es ist 1 Rechteck erstellt worden."; 
            }
            else
            {
                return $"Es sind {RectangleCreated} Rechtecke erstellt worden.";
            }
        }
    }
}