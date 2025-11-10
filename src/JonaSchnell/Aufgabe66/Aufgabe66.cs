using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.JonaSchnell.Aufgabe66
{
    public class Aufgabe66
    {

        public static void PrintPersonenAufgabe()
        {
            Personen[] people = new Personen[1];
            people[0] = new Personen();
            people[0].Name = "Julian";
            people[0].Geburtsdatum = DateTime.Parse("04/06/1918");
            people[0].Größe = 100;
            people[0].Gewicht = 5;
            people[0].Print();
        }
    }
}