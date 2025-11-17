using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe71
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
        }

        public override void Fahren(double distanz)
        {
            Kilometerstand += distanz;
        }
        public override string ToString()
        {
            return $"{base.DruckeDatenblatt()}Anzahl der Türen: {AnzahlDerTueren}";
        }
    }
}