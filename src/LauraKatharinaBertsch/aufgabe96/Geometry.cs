namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe96
{
    public class Geometrie
    {
        public static void Start()
        {
            List<Rectangle> rectangles = new List<Rectangle>();
            rectangles.Add(new Rectangle(5, 4));
            rectangles.Add(new Rectangle(6, 2));

            foreach (Rectangle r in rectangles)
            {
                Console.WriteLine(r);
                Console.WriteLine("Umfang: " + Rectangle.CalculateScope(r) + "cm");
                Console.WriteLine("Flächeninhalt: " + Rectangle.CalculateSurfaceArea(r) + "cm²");
                Console.WriteLine();
            }

            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(5));
            triangles.Add(new Triangle(6));

            foreach (Triangle t in triangles)
            {
                Console.WriteLine(t);
                Console.WriteLine("Umfang: " + Triangle.CalculateScope(t) + "cm");
                Console.WriteLine("Flächeninhalt: " + Triangle.CalculateSurfaceArea(t) + "cm²");
                Console.WriteLine();
            }

            List<Circle> circles = new List<Circle>();
            circles.Add(new Circle(5));
            circles.Add(new Circle(6));

            foreach (Circle c in circles)
            {
                Console.WriteLine(c);
                Console.WriteLine("Umfang: " + Circle.CalculateScope(c) + "cm");
                Console.WriteLine("Flächeninhalt: " + Circle.CalculateSurfaceArea(c) + "cm²");
                Console.WriteLine();
            }
            Triangle.PrintAmountOfCreatedTriangles();
            Circle.PrintAmountOfCreatedCircles();
            Rectangle.PrintAmountOfCreatedTriangles();

        }
    }
}