namespace Appdevhb25.JonaSchnell.Aufgabe96
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public string ElementTyp { get; set; }
        public Figure(string name, string elementTyp)
        {
            Name = name;
            ElementTyp = elementTyp;
        }
        public abstract double CalculateCircumference();
        //Circumference = Umfang
        public abstract double CalculateArea();
    }
}