namespace Appdevhb25.LiaLouiseNatter.Aufgabe96
{
    public class Circle:AbstractFigure,IScalable
    {
        public static int countFigures{get;set;}
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if(value <= 0)
                {
                    System.Console.WriteLine("The radius has to be bigger than 0");
                }
                else
                {
                    _radius = value;
                }
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
            name = "Amazing Circle";
            elementType ="Circle";
            countFigures++;
            area = calculateArea();
            extent = calculateExtent();
        }

        public override double calculateExtent()
        {
            double extent = 2*Math.PI*Radius;
            
            return Math.Round(extent, 3);
        }

        public override double calculateArea()
        {
            double area = Math.PI * Radius * Radius;
            return Math.Round(area,3);
        }

        public void Scale(double toAdd)
        {
            Radius += toAdd;
            area = calculateArea();
            extent = calculateExtent();
        }
          public override string ToString()
        {
            return base.ToString() + $"Radius: {Radius}\nExtent: {extent}\nArea: {area}\nCounted Figures: {countFigures}";
        }
    }
}