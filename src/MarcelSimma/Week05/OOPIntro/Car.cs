namespace Appdevhb25.MarcelSimma.OOPIntro
{
    public class Car
    {
        // Instanzattribute, weil nicht static
        // vorerst sind alle Felder und Attribute public, diese schreibt man groß
        public string Farbe;

        // Standardkonstruktor ist immer verfügbar
        public Car()
        {

        }

        // Instanzmethode, weil nicht static
        public void PrintColor()
        {
            System.Console.WriteLine(Farbe);
        }
    }
}