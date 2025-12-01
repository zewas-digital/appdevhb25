using System.Net;
using System.Xml;

namespace Appdevhb25.NoahHois.Aufgabe96
{
    public class StartMethod
    {

        public static void Start()
        {
            List<Figur> Gustav = new List<Figur>();
            Kreis kreis = new Kreis(3, "Kreis", "Krais");
            Rechteck rechteck = new Rechteck(4, 2, "Rechteck", "Rechteck");
            Gustav.Add(kreis);
            Gustav.Add(rechteck);
            foreach (var i in Gustav)
            {
                System.Console.WriteLine(i.ToString);
            }

        }
    }
}