using System.ComponentModel.DataAnnotations;

namespace Appdevhb25.JonaSchnell.Aufgabe96
{
    public class Rectangle : Figure
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(string name, double length, double width) : base(name, "Rectangle")
        {
            Length = length;
            Width = width;

        }
        public override double CalculateCircumference()
        {
            return (Length + Width) * 2;
        }
        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}