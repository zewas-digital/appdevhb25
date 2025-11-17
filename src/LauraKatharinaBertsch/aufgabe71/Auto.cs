namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe71
{
    public class Auto : AbstrakteFahrzeuge
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
        public override void Fahren(double distanz)
        {
            Kilometerstand += distanz;
            Console.WriteLine("Distanz: " + distanz);
            Console.WriteLine("neuer Kilometerstand: " + Kilometerstand);
        }
        public static void PrintAnzahlDerProduziertenAutos()
        {
            Console.WriteLine("Anzahl der produzierten Autos: " + AnzahlDerProduziertenAutos);
        }

        public override string ToString()
        {
            return "Das ist ein Auto";
        }
    }
}