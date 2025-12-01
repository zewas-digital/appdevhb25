namespace Appdevhb25.JulianMatt.Aufgabe96;

public abstract class Figure
{
    public string Name { get; protected set; }

    public string ElementaryType { get; protected set; }

    public abstract double Circumference();
    public abstract double Area();

    public override string ToString()
    {
        return $"Name: {Name}\nTyp: {ElementaryType}";
    }

}