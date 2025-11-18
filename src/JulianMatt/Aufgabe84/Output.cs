namespace Appdevhb25.JulianMatt.Aufgabe84
{
    public class Output
    {
        public static void Start84()
        {
            List<IGegenstand> inventarliste = new List<IGegenstand>();

            inventarliste.Add(new Auto(4, "2313"));
            inventarliste.Add(new Motorrad("KTM", "321"));
            inventarliste.Add(new Fotoapparat(23.12, "3wd2"));
            inventarliste.Add(new Fahrzeug ("HHI23", "34SdeE"));

            foreach (IGegenstand elem in inventarliste)
            {
                System.Console.WriteLine(elem.GetGegenstandInfo());
            }
        }
    }
}