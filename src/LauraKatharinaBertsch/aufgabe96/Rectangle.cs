using System.Security.Cryptography.X509Certificates;
using Appdevhb25.LauraKatharinaBertsch.Aufgabe52;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe96
{
    public class Rectangle : Figure, IScalable
    {
        public override double SurfaceArea { get; set; }
        public override double Scope { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public static int AmountOfCreatedRectangles;
        public Rectangle(double length, double width)
        {
            Name = "Hello Kitty";
            ElementType = "Rechteck";
            Length = length;
            Width = width;
            AmountOfCreatedRectangles++;
        }
        public static double CalculateSurfaceArea(Rectangle r)
        {
            double surfaceArea = r.Length * r.Width;
            return surfaceArea;
        }
        public static double CalculateScope(Rectangle r)
        {
            double scope = r.Length * 2 + r.Width * 2;
            return scope;
        }
        public static void PrintAmountOfCreatedTriangles()
        {
            Console.WriteLine("Anzahl der erstellten Rechtecke: " + AmountOfCreatedRectangles);
        }
        public void Scale(double factor)
        {
            Length = Length * factor;
            Width = Width * factor;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nTyp: {ElementType}\nLänge: {Length}cm\nBreite: {Width}cm";
        }
    }
}