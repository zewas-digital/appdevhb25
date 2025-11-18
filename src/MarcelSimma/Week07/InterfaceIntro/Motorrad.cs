namespace Appdevhb25.MarcelSimma.Week07.InterfaceIntro
{
    public class Motorrad : IGegenstand
    {
        public string Inventarnummer {get; set; }
        public string Marke;
        public Motorrad(string marke)
        {
            Marke = marke;
        }

        public string PrintGegenstand()
        {
            return "Das ist ein Motorrad";
        }
    }
}