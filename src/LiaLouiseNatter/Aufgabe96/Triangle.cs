namespace Appdevhb25.LiaLouiseNatter.Aufgabe96
{
    public class Triangle : AbstractFigure 
    {
        public static int countFigures{get;set;}
        private double _sideA;
        public double SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                if(value <= 0)
                {
                    System.Console.WriteLine("Length needs to be longer than 0");
                }
                else
                {
                    _sideA = value;
                }
            }
        }

        public Triangle(double sideA)
        {
            SideA = sideA;
            elementType = "Triangle";
            name = "Amazing Triangle";
            countFigures++;
            area = calculateArea();
            extent = calculateExtent();
        }

        public override double calculateArea()
        {
            double area = SideA * SideA * Math.Sqrt(3) / 2;

            return Math.Round(area,3);
        }
        public override double calculateExtent()
        {
            double extent = SideA * 3;
            return Math.Round(extent,3);
        }

          public override string ToString()
        {
            return base.ToString() + $"Length: {SideA}\nExtent: {extent}\nArea: {area}\nCounted Figures: {countFigures}";
        }
    }
}