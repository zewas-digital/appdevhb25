namespace Appdevhb25.JonaSchnell.Aufgabe96
{
    public interface FigureShape
    {
        string Name { get; }

        double CalculateArea();
        double CalculateCircumference();
    }
}