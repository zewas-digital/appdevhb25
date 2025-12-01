using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe97
{

    public class Triangle : Shape
    {
        private double sideLength;
        public double SideLength
        {
            get
            {
                return sideLength;
            }
            set
            {
                sideLength = value;
                CalcCircumference();
                CalcSurfaceArea();
            }
        }
        public static int AmountProduced { get; set; }


        public Triangle(string name, double sideLength) : base(name)
        {
            SideLength = sideLength;
            ElementType = "Dreieck";
            AmountProduced++;
        }


        public override double CalcCircumference()
        {
            Circumference = Math.Round(SideLength * 3, 2);
            return Circumference;
        }

        public override double CalcSurfaceArea()
        {
            SurfaceArea = Math.Round(Math.Sqrt(3) / 4 * Math.Pow(SideLength, 2), 2);
            return SurfaceArea;
        }

        public override string ToString()
        {
            return base.ToString() + $"Seitenlänge: {SideLength}\n";
        }
    }
}
