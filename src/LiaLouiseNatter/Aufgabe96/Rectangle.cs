using System.Runtime.ConstrainedExecution;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe96
{
    public class Rectangle : AbstractFigure, IScalable
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
        private double _sideB;
        public double SideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                if(value <= 0)
                {
                    System.Console.WriteLine("Length needs to be longer than 0");
                }
                else
                {
                    _sideB = value;
                }
            }
        }

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
            elementType = "Triangle";
            name = "Amazing Triangle";
            countFigures++;
            area = calculateArea();
            extent = calculateExtent();
        }

        public override double calculateArea()
        {
            double area = SideA * SideB;
            return area;
        }
        public override double calculateExtent()
        {
            double extent = (SideA * 2) + (SideB * 2);
            return extent;
        }

        public void Scale(double toAdd)
        {
            SideA += toAdd;
            SideB += toAdd;
            area = calculateArea();
            extent = calculateExtent();
        }

        public override string ToString()
        {
            return base.ToString() + $"Length: {SideA}\nWidth: {SideB}\nExtent: {extent}\nArea: {area}\nCounted Figures: {countFigures}";
        }
    }
}