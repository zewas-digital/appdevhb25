namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe70
{
    public class Auto : Fahrzeuge
    {
        public static int AnzahlDerProduziertenAutos;
        public int _anzahlDerTueren;
        public int AnzahlDerTueren
        {
            get
            {
                return _anzahlDerTueren;
            }
            private set
            {
                _anzahlDerTueren = value;
            }
        }

        public Auto(int anzahlDerTueren) : base("blau", "AT123", 0)
        {
            AnzahlDerTueren = anzahlDerTueren;
            AnzahlDerProduziertenAutos++;
        }
        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            Console.WriteLine("Anzahl der Türen: " + AnzahlDerTueren);
        }
        public void Fahren(double distanz)
        {
            Console.WriteLine("Distanz: " + distanz);
            Console.WriteLine("neuer Kilometerstand: " + (Kilometerstand + distanz));
        }
        public void PrintAnzahlDerProduziertenAutos()
        {
            Console.WriteLine("Anzahl der produzierten Autos: " + AnzahlDerProduziertenAutos);
        }
    }
}