using System.Globalization;
using System.Runtime.InteropServices;
using ZstdSharp.Unsafe;

namespace Appdevhb25.SheilaMayJaro.Aufgabe96
{
    public class Aufgabe96
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 96)");
            List<Shape> shapes = new List<Shape>();
            Rectangle rectangle = new Rectangle(5, 8, "Rechteck hihi");
            Circle circle = new Circle(7, "Kreis woop");
            EquiliteralTriangle equiliteralTriangle = new EquiliteralTriangle(8, "Gleichseitiges Dreieck damn");
            shapes.Add(rectangle);
            shapes.Add(circle);
            shapes.Add(equiliteralTriangle);
            shapes.Add(new EquiliteralTriangle(4, "hello world"));
            shapes.Add(new Rectangle(1, 2, "asdf"));
            foreach (Shape shape in shapes)
            {
                System.Console.WriteLine($"{shape}");
                System.Console.WriteLine();
            }
            circle.Scaling(3.0);
            foreach (Shape shape in shapes)
            {
                System.Console.WriteLine($"{shape}");
                System.Console.WriteLine();
            }
            rectangle = new Rectangle(0, 3, "mimimimi");
            shapes.Add(rectangle);
            foreach (Shape shape in shapes)
            {
                System.Console.WriteLine($"{shape}");
                System.Console.WriteLine();
            }
            Console.WriteLine(rectangle.ToString());
            rectangle.Scaling(4.2);
            Console.WriteLine(rectangle.ToString());
            circle.Scaling(-0.5);
            System.Console.WriteLine(circle.ToString());
            rectangle.Scaling(-10);
            Console.WriteLine(rectangle.ToString());
            circle = new Circle(7, "Teufelskreis"); 
            Console.WriteLine(Rectangle.DisplayNumberOfRectangles());
            Console.WriteLine(EquiliteralTriangle.DisplayNumberOfTriangles());
            Console.WriteLine(Circle.DisplayNumberOfCircles());
        }
    }
}