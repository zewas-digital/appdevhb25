namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe96
{
    public class Triangle : Figure
    {

        public override double SurfaceArea { get; set; }
        public override double Scope { get; set; }
        public double Side { get; set; }
        public static int AmountOfCreatedTriangles { get; set; }

        public Triangle(double side)
        {
            Name = "Hello Kitty";
            ElementType = "Dreieck";
            Side = side;
            AmountOfCreatedTriangles++;
        }
        public static double CalculateSurfaceArea(Triangle t)
        {
            double surfaceArea = Math.Sqrt(t.Side) / 4 * (t.Side * t.Side);
            return surfaceArea;
        }
        public static double CalculateScope(Triangle t)
        {
            double scope = t.Side * 3;
            return scope;
        }
        public static void PrintAmountOfCreatedTriangles()
        {
            Console.WriteLine("Anzahl der erstellten Dreiecke: " + AmountOfCreatedTriangles);
        }
        public override string ToString()
        {
            return $"Name: {Name}\nTyp: {ElementType}\nSeitenlänge: {Side}";
        }
    }
}
