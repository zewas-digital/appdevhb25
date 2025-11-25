using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe96
{

    public class Rectangle : Shape, IScalable
    {
        private double width;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                CalcCircumference();
                CalcSurfaceArea();
            }
        }
        private double length;
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
                CalcCircumference();
                CalcSurfaceArea();
            }
        }
        public static int AmountProduced { get; set; }

        public Rectangle(string name, double width, double length) : base(name)
        {
            Width = width;
            Length = length;
            ElementType = "Dreieck";
            AmountProduced++;
        }


        public override double CalcCircumference()
        {
            Circumference = Math.Round(Width * 2 + Length * 2, 2);
            return Circumference;
        }

        public override double CalcSurfaceArea()
        {
            SurfaceArea = Math.Round(Width * Length, 2);
            return SurfaceArea;
        }

        public override string ToString()
        {
            return base.ToString() + $"Länge: {Width}\nBreite: {Width}";
        }

        public void Scale(double factor)
        {
            Width *= factor;
            Length *= factor;
        }
    }
}
