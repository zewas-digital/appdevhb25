namespace Appdevhb25.NoahHois.Aufgabe96
{
    public class Dreieck : Figur
    {
        public double SideLength { get; private set; }
        public static int NumberOfTriangles { get; private set; }

        public Dreieck(double sideLenght, string type, string designnation) : base(type, designnation)
        {
            SideLength = sideLenght;
            NumberOfTriangles++;
        }
        public override double CalculateScope()
        {
            return SideLength * 3;
        }
        public override double CalculateArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(SideLength, 2);
        }
    }
}