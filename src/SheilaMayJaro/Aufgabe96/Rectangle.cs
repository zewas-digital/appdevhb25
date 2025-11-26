using System.Reflection.Metadata.Ecma335;

namespace Appdevhb25.SheilaMayJaro.Aufgabe96
{
    public class Rectangle : Shape, IScalable
    {
        public double Length
        {
            get { return Length; }
            private set
            {
                if (value > 0)
                {
                    Length = value;
                }
                else
                {
                    System.Console.WriteLine("Der Wert kann nicht 0 sein oder eine negative Zahl.");
                }
            }
        }
        public double Width
        {
            get { return Width; }
            private set
            {
                if (value > 0)
                {
                    Width = value;
                }
                else
                {
                    System.Console.WriteLine("Der Wert kann nicht 0 sein oder eine negative Zahl.");
                }
            }
        }
        public double Area { get; private set; }
        public double Perimeter { get; private set; }
        public static int RectangleCreated
        {
            get { return RectangleCreated; }
            private set
            {
                if (value > RectangleCreated)
                {
                    RectangleCreated = value;
                }
                else
                {
                    System.Console.WriteLine("Der Wert kann nicht kleiner sein, als der momentane Wert.");
                }
            }
        }
        public Rectangle(int width, int length, string name) : base(name)
        {
            Name = name;
            Elementtype = "Rechteck";
            Width = width;
            Length = length;
            RectangleCreated++;
        }
        public override double CalculateArea()
        {
            double area = Width * Length;
            return Area = area;
        }
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (Width + Length);
            return Perimeter = perimeter;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nLänge: {Length}\nBreite: {Width}\nUmfang: {Perimeter} \nFlächeninhalt: {Area} ";
        }
        public void Scaling(double factor)
        {
            Width *= factor;
            Length *= factor;
        }
        public void DisplayNumberOfRectangles()
        {
            if (RectangleCreated == 1)
            {
                System.Console.WriteLine($"Es ist {RectangleCreated} Kreis erstellt worden.");
            }
            else
            {
                System.Console.WriteLine($"Es sind {RectangleCreated} Kreise erstellt wurden.");
            }
        }
    }
}