namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe96
{
    public class Circle : Figure, IScalable
    {
        public override double SurfaceArea { get; set; }
        public override double Scope { get; set; }
        public double Radius { get; set; }
        public static int AmountOfCreatedCircles { get; set; }


        public Circle(double radius)
        {
            Name = "Hello Kitty";
            ElementType = "Kreis";
            Radius = radius;
            AmountOfCreatedCircles++;
        }
        public static double CalculateSurfaceArea(Circle c)
        {
            double surfaceArea = 2 * Math.PI * c.Radius;
            return surfaceArea;
        }
        public static void PrintAmountOfCreatedCircles()
        {
            Console.WriteLine("Anzahl der erstellten Kreise: " + AmountOfCreatedCircles);
        }
        public static double CalculateScope(Circle c)
        {
            double scope = Math.PI * (c.Radius * c.Radius);
            return scope;
        }
        public void Scale(double factor)
        {
            Radius = Radius * factor;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nTyp: {ElementType}\nRadius: {Radius}";
        }
    }
}
