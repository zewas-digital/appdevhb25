namespace Appdevhb25.NoahHois.Aufgabe96
{
    public class Kreis : Figur, IScaleable
    {
        public double Radius { get; private set; }
        public static int NumberOfCircles { get; private set; }

        public Kreis(double radius, string type, string designnation) : base(type, designnation)
        {
            Radius = radius;
            NumberOfCircles++;
        }
        public override double CalculateScope()
        {
            return 2 * Math.PI * Radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public void Scalefactor(double factor)
        {
            Radius *= factor;
        }
    }
}