using System.Runtime.InteropServices;

namespace Appdevhb25.JulianMatt.Aufgabe96;

public class Output
{
    public static void Start96()
    {
        List<Figure> figures = new List<Figure>();

        Circle circle1 = new Circle(5);
        System.Console.WriteLine(circle1.ToString());
        figures.Add(circle1);
        System.Console.WriteLine();

        Rectangle rectangle1 = new Rectangle(4, 6);
        System.Console.WriteLine(rectangle1.ToString());
        figures.Add(rectangle1);
        System.Console.WriteLine();

        EquilateralTriangle triangle1 = new EquilateralTriangle(3);
        figures.Add(triangle1);
        System.Console.WriteLine(triangle1.ToString());
        System.Console.WriteLine();

        ScaleObj(circle1, rectangle1, triangle1);

        System.Console.WriteLine();
        Circle.GiveOutCount();
        Rectangle.GiveOutCount();
        EquilateralTriangle.GiveOutCount();

    }

    public static void ScaleObj(Circle circle1, Rectangle rectangle1, EquilateralTriangle triangle1)
    {
        System.Console.WriteLine("Welche Form wollen sie bearbeiten");
        string input = Console.ReadLine();
        if (input.ToLower() == "dreieck")
        {
            System.Console.WriteLine("Wie viel mahl wollen sie es skalieren?");
            int factor = Convert.ToInt32(Console.ReadLine());
            triangle1.Scale(factor);
        }
        else if (input.ToLower() == "kreis")
        {
            System.Console.WriteLine("Wie viel mahl wollen sie es skalieren?");
            int factor = Convert.ToInt32(Console.ReadLine());
            circle1.Scale(factor);
        }
        else if (input.ToLower() == "rechteck")
        {
            System.Console.WriteLine("Wie viel mahl wollen sie es skalieren?");
            int factor = Convert.ToInt32(Console.ReadLine());
            rectangle1.Scale(factor);
        }
        else
        {
            System.Console.WriteLine("Invalide Eingabe");
        }
    }
}