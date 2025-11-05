
namespace Appdevhb25.MarcelSimma.Week05.VererbungIntro
{
    // Auto ist eine erbende Klasse = Subklasse = Kindklasse = abgeleitete Klasse
    // public class <Subklasse> : <Superklasse>
    public class Auto : Fahrzeug
    {
        // Attribute
        public int AnzahlDerTueren;
        public static int AnzahlDerProduziertenAutos = 0;

        /*
        Die Attribute
          - Farbe
          - Kilometerstand
          - Kennzeichen
        sind bereits in der Superklasse Fahrzeug definiert und werden an Auto vererbt.
        Daher müssen sie hier nicht nochmals definiert werden
        */

        // base() ruft den Konstruktor der Superklasse auf
        // Die Argumente, welche in der Superklasse definiert werden, müssen an base() übergeben werden.
        public Auto(string farbe, int anzahlDerTueren) : base(farbe)
        {
            AnzahlDerTueren = anzahlDerTueren;
            AnzahlDerProduziertenAutos++;
        }
    }
}

