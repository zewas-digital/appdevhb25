using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Appdevhb25.JulianMatt.Aufgabe96;

public class Circle : Figure, ISkalierbar
{
    private static int Count = 0;

    private double _radius;

    public double Radius
    {
        get { return _radius; }
        set
        {
            if (value <= 0)
            {
                System.Console.WriteLine("Invalide Eingabe");
            }
            else
            {
                _radius = value;
            }
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
        Name = $"Kreis Nr.{Count + 1}";
        ElementaryType = "Kreis";
        Count++;
    }

    public static void GiveOutCount()
    {
        System.Console.WriteLine($"Es wurden schon {Count} Kreise gemacht");
    }

    public void Scale(double faktor)
    {
        if (faktor <= 0)
        {
            System.Console.WriteLine("Diese Eingabe ist nicht gültig");
        }
        else
        {
            Radius *= faktor;
            System.Console.WriteLine(ToString());
        }
    }

    public override double Circumference()
    {
        return Math.Round(2 * Math.PI * Radius, 2);
    }

    public override double Area()
    {
        return Math.Round(Math.PI * Radius * Radius, 2);
    }

    public override string ToString()
    {
        return base.ToString() +
        $"\nRadius: {Radius}" +
        $"\nUmfang: {Circumference()}" +
        $"\nFläche: {Area()}";
    }


}