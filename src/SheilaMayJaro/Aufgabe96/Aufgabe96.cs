using System.Globalization;

namespace Appdevhb25.SheilaMayJaro.Aufgabe96
{
    public class Aufgabe96
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 96)");
            List<Shape> shapes = new List<Shape>(); 
            Rectangle rectangle = new Rectangle(5,8, "Rechteck hihi"); 
            Circle circle = new Circle(7, "Kreis woop"); 
            EquiliteralTriangle equiliteralTriangle = new EquiliteralTriangle(8, "Gleichseitiges Dreieck damn"); 
            shapes.Add(rectangle); 
            shapes.Add(circle); 
            shapes.Add(equiliteralTriangle); 
            foreach (Shape shape in shapes)
            {
                shape.CalculateArea(); 
                shape.CalculatePerimeter(); 
                System.Console.WriteLine($"{shape}");
            }
            rectangle.Scaling(3); 
            circle.Scaling(3); 
            System.Console.WriteLine("----------------------------------------------------");
            foreach (Shape shape in shapes)
            {
                shape.CalculateArea(); 
                shape.CalculatePerimeter(); 
                System.Console.WriteLine($"{shape}");
            }
        }
    }
}