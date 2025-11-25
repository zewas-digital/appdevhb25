namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe96
{
    public class Geometrie
    {
        public static void Start()
        {
            Rechteck rechteck1 = new Rechteck("Cooles Rechteck", 3, 4);
            GleichseitigesDreieck dreieck1 = new GleichseitigesDreieck("Elegantes Dreieck", 2);
            GleichseitigesDreieck dreieck2 = new GleichseitigesDreieck("Echtes Dreieck", 5);
            Kreis kreis1 = new Kreis("Fabulöser Kreis", 4);

            List<Figur> figuren = [rechteck1, dreieck1, dreieck2, kreis1];

            kreis1.Skalieren(2);

            foreach (var figur in figuren)
            {
                Console.WriteLine(figur);
                Console.WriteLine();
            }

            Rechteck.AnzahlAnzeigen();
            Kreis.AnzahlAnzeigen();
            GleichseitigesDreieck.AnzahlAnzeigen();
        }
    }
}