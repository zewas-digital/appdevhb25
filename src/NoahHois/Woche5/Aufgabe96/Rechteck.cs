namespace Appdevhb25.NoahHois.Aufgabe96
{
    public class Rechteck : Figur
    {
        public double Length { get; private set; }
        public double Width { get; private set; }
        public static int NumberOfRectangle { get; private set; }

        public Rechteck(double length, double width, string type, string designnation) : base(type, designnation)
        {
            Length = length;
            Width = width;
            NumberOfRectangle++;
        }
        public override double CalculateScope()
        {
            return (Length + Width) * 2;
        }
        public override double CalculateArea()
        {
            return Length * Width;
        }
        public void Scalefactor(double factor)
        {
            Length *= factor;
            Width *= factor;
        }
    }
}