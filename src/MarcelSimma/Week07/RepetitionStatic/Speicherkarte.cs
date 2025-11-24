namespace Appdevhb25.MarcelSimma.RepetitionStatic
{
    // Diese Klasse enthält alle Informationen zur Speicherkarte
    public class Speicherkarte
    {
        public double Kapazitaet;
        public static int AnzahlDerProduziertenSpeicherkarten = 0;

        // Jedes mal, wenn ein neues Objekt mit "new" erzeugt wird, verwendet man einen Konstruktor.
        public Speicherkarte(double kapazitaet)
        {
            Kapazitaet = kapazitaet;
            AnzahlDerProduziertenSpeicherkarten++;
        }
    }
}