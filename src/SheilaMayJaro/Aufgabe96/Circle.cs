namespace Appdevhb25.SheilaMayJaro.Aufgabe96
{
    public class Circle : Shape, IScalable
    {
        public double Radius
        {
            get { return Radius; }
            private set
            {
                if (value > 0)
                {
                    Radius = value;
                }
                else
                {
                    System.Console.WriteLine("Der Wert kann nicht 0 sein oder eine negative Zahl.");
                }
            }
        }
        public double Area { get; private set; }
        public double Perimeter { get; private set; }
        public int CircleCreated
        {
            get
            {
                return CircleCreated;
            }

            private set
            {
                if (value > CircleCreated)
                {
                    CircleCreated = value;
                }
                else
                {
                    System.Console.WriteLine("Der Wert kann nicht kleiner sein, als der momentane Wert.");
                }
            }
        }
        public Circle(int radius, string name) : base(name)
        {
            Name = name;
            Elementtype = "Kreis";
            Radius = radius;
            CircleCreated++;
        }
        public override double CalculateArea()
        {
            Area = Math.PI * (Radius * Radius);
            return Area;
        }
        public override double CalculatePerimeter()
        {
            Perimeter = 2 * Math.PI * Radius;
            return Perimeter;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nRadius: {Radius}\nUmfang: {Perimeter:F2} \nFlächeninhalt: {Area:F2} ";
        }
        public void Scaling(double factor)
        {
            Radius *= factor;
        }
        public void DisplayNumberOfCircles()
        {
            if (CircleCreated == 1)
            {
                System.Console.WriteLine($"Es ist {CircleCreated} Kreis erstellt worden.");
            }
            else
            {
                System.Console.WriteLine($"Es sind {CircleCreated} Kreise erstellt wurden.");
            }
        }
    }

}