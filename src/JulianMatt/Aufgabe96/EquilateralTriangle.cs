namespace Appdevhb25.JulianMatt.Aufgabe96;

public class EquilateralTriangle : Figure, ISkalierbar
{
    private static int Count = 0;

    private double _sideLength;

    public double SideLength
    {
        get { return _sideLength; }
        set
        {
            if (value <= 0)
            {
                System.Console.WriteLine("Invalide Eingabe");
            }
            else
            {
                _sideLength = value;
            }
        }
    }

    public EquilateralTriangle(double sideLength)
    {
        SideLength = sideLength;
        Name = $"Dreieck Nr.{Count + 1}";
        ElementaryType = "Gleichseitiges Dreieck";
        Count++;
    }

    public static void GiveOutCount()
    {
        System.Console.WriteLine($"Es wurden schon {Count} Gleichseitige Dreiecke gemacht");
    }

    public void Scale(double faktor)
    {

        if (faktor <= 0)
        {
            System.Console.WriteLine("Diese Eingabe ist nicht gültig");
        }
        else
        {
            SideLength *= faktor;
            System.Console.WriteLine(ToString());
        }
    }

    public override double Circumference()
    {
        return Math.Round(3 * SideLength, 2);
    }

    public override double Area()
    {
        return Math.Round((SideLength * SideLength) / (Math.Sqrt(3) * 4), 2);
    }

    public override string ToString()
    {
        return base.ToString() +
        $"\nRadius: {SideLength}" +
        $"\nUmfang: {Circumference()}" +
        $"\nFläche: {Area()}";
    }

}