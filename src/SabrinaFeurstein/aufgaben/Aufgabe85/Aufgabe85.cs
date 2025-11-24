namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe85
{
    public class Aufgabe85
    {
        public static void Start()
        {
            Telefonbuch telefonbuch = new Telefonbuch();

            telefonbuch.EintragHinzufuegen("Goth", "Willow Creek", "+1 45 32355");
            telefonbuch.EintragHinzufuegen("Smith", "Brighton", "+44 274 23769");
            telefonbuch.EintragHinzufuegen("Flatz", "Linz", "+43 655 98455");
            telefonbuch.EintragHinzufuegen("Mayer", "Innsbruck", "+43 78 29034");

            telefonbuch.EintragVeraendern("smith", "Brown", "Brighton", "+44 274 23769");
            telefonbuch.EintragLoeschen("mayer");

            foreach (var eintrag in telefonbuch.TelefonbuchListe)
            {
                Console.WriteLine($"{eintrag.Ort} - {eintrag.Nachname} - {eintrag.Telefonnummer}");
            }
        }
    }
}