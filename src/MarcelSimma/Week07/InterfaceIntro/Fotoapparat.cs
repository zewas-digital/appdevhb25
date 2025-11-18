namespace Appdevhb25.MarcelSimma.Week07.InterfaceIntro
{
    public class Fotoapparat : IGegenstand
    {
        public string Inventarnummer { get; set; }
        public double Brennweite;
        public Fotoapparat(double brennweite)
        {
            brennweite = Brennweite;   
        }

        public string PrintGegenstand()
        {
            return "Das ist ein Fotoapparat";
        }
    }
}