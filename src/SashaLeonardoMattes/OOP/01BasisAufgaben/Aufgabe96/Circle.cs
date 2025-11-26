using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe96
{

    public class Circle : Shape, IScalable
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                CalcCircumference();
                CalcSurfaceArea();
            }
        }

        public static int AmountProduced { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
            ElementType = "Kreis";
            AmountProduced++;
        }


        public override double CalcCircumference()
        {
            Circumference = Math.Round(2 * Math.PI * Radius, 2);
            return Circumference;
        }

        public override double CalcSurfaceArea()
        {
            SurfaceArea = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
            return SurfaceArea;
        }

        public override string ToString()
        {
            return base.ToString() + $"Radius: {Radius}\n";
        }

        public void Scale(double factor)
        {
            Radius *= factor;
        }
    }
}
