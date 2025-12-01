namespace Appdevhb25.SheilaMayJaro.Aufgabe96
{
    public class EquiliteralTriangle : Shape, IScalable
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
        public double Area { get; private set; }
        public double Perimeter { get; private set; }
        public int EquiliteralTriangleCreated
        {
            get { return EquiliteralTriangleCreated; }
            private set
            {
                if (value > EquiliteralTriangleCreated)
                {
                    EquiliteralTriangleCreated = value;
                }
                else
                {
                    System.Console.WriteLine("Der Wert kann nicht kleiner sein, als der momentane Wert.");
                }
            }
        }
        public EquiliteralTriangle(double length, string name) : base(name)
        {
            Name = name;
            Elementtype = "Gleichseitiges Dreieck";
            Length = length;
            EquiliteralTriangleCreated++;
        }
        public override double CalculateArea()
        {
            Area = Length * (Length * Math.Sqrt(3 / 2));
            return Area;
        }
        public override double CalculatePerimeter()
        {
            Perimeter = Length * 3;
            return Perimeter;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nLänge: {Length}\nUmfang: {Perimeter} \nFlächeninhalt: {Area} ";
        }
        public void Scaling(double factor)
        {
            Length *= factor;
        }
        public void DisplayNumberOfTriangles()
        {
            if (EquiliteralTriangleCreated == 1)
            {
                System.Console.WriteLine($"Es ist {EquiliteralTriangleCreated} Kreis erstellt worden.");
            }
            else
            {
                System.Console.WriteLine($"Es sind {EquiliteralTriangleCreated} Kreise erstellt wurden.");
            }
        }
    }
}