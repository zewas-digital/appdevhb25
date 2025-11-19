namespace Appdevhb25.JulianMatt.Aufgabe84
{
    public class Output
    {
        public static void Start84()
        {
            List<IGegenstand> inventarliste = new List<IGegenstand>();

            inventarliste.Add(new Auto(5, "ABC123"));
            inventarliste.Add(new Motorrad("Harley Davidson", "XYZ789"));
            inventarliste.Add(new Fotoapparat(23.12));

            foreach (IGegenstand elem in inventarliste)
            {
                System.Console.WriteLine(elem.GetGegenstandInfo());
            }
        }
    }
}