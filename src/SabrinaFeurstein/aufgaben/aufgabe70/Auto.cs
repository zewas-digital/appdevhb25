using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe70
{
    public class Auto : Fahrzeug
    {
        private int _anzahlDerTueren;
        public int AnzahlDerTueren
        {
            get
            {
                return _anzahlDerTueren;
            }
            set
            {
                if (value > 0)
                    _anzahlDerTueren = value;
                else
                    Console.WriteLine("Ein Auto muss mindestens eine Tür haben!");
            }
        }

        public static int AnzahlDerProduziertenAutos;

        public Auto(string farbe, string kennzeichen, double kilometerstand, int anzahlDerTueren) : base(farbe, kennzeichen, kilometerstand)
        {
            AnzahlDerTueren = anzahlDerTueren;
            AnzahlDerProduziertenAutos++;
            AnzahlDerProduziertenFahrzeuge++;
        }

        public void Fahren(double distanz)
        {
            Kilometerstand += distanz;
        }
        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            Console.WriteLine($"Anzahl der Türen: {AnzahlDerTueren}");
        }
    }
}