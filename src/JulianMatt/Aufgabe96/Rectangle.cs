namespace Appdevhb25.JulianMatt.Aufgabe96;

public class Rectangle : Figure, ISkalierbar
{
    private static int Count = 0;

    private double _with;

    public double With
    {
        get { return _with; }
        set
        {
            if (value <= 0)
            {
                System.Console.WriteLine("Invalide Eingabe");
            }
            else
            {
                _with = value;
            }
        }
    }

    private double _hight;

    public double Hight
    {
        get { return _hight; }
        set
        {
            if (value <= 0)
            {
                System.Console.WriteLine("Invalide Eingabe");
            }
            else
            {
                _hight = value;
            }
        }
    }

    public Rectangle(double with, double höhe)
    {
        With = with;
        Hight = höhe;
        Name = $"Rechteck Nr.{Count + 1}";
        ElementaryType = "Rechteck";
        Count++;
    }

    public static void GiveOutCount()
    {
        System.Console.WriteLine($"Es wurden schon {Count} Rechtecke gemacht");
    }

    public void Scale(double faktor)
    {

        if (faktor == 0)
        {
            System.Console.WriteLine("Diese Eingabe ist nicht gültig");
        }
        else
        {
            With *= faktor;
            Hight *= faktor;
            System.Console.WriteLine(ToString());
        }
    }

    public override double Circumference()
    {
        return Math.Round((With + Hight) * 2, 2);
    }

    public override double Area()
    {
        return Math.Round(With * Hight, 2);
    }

    public override string ToString()
    {
        return base.ToString() +
        $"\nRadius: {With}" +
        $"\nUmfang: {Circumference()}" +
        $"\nFläche: {Area()}";
    }

}