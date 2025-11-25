using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe96
{

    public abstract class Shape
    {
        public string? Name { get; set; }
        public string? ElementType { get; set; }
        public double SurfaceArea { get; set ; }
        public double Circumference { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public abstract double CalcSurfaceArea();
        public abstract double CalcCircumference();
        public override string ToString()
        {
            return $"Name des Elements: {Name}\nTyp: {ElementType}\nUmfang: {Circumference}\nFlächeninhalt: {SurfaceArea}\n";
        }

    }
}
