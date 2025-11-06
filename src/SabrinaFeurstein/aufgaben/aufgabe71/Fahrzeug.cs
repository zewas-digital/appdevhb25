namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe71
{
    public abstract class Fahrzeug
    {
        private string _farbe;
        private string _kennzeichen;
        private double _kilometerstand;

        public string Farbe
        {
            get
            {
                return _farbe;
            }
            private set
            {
                _farbe = value;
            }
        }
        public string Kennzeichen
        {
            get
            {
                return _kennzeichen;
            }
            set
            {
                if (value.Length > 2 && value.Length < 10)
                    _kennzeichen = value;
                else
                    Console.WriteLine("Ungültiges Kennzeichen!");
            }
        }
        public double Kilometerstand
        {
            get
            {
                return _kilometerstand;
            }
            set
            {
                if (value >= _kilometerstand)
                    _kilometerstand = value;
                else if (value < 0)
                    Console.WriteLine("Kilometerstand kann nicht negativ sein!");
                else
                    Console.WriteLine("Kilometerstand darf nicht zurückgesetzt werden!");
            }
        }

        public static int AnzahlDerProduziertenFahrzeuge;

        public Fahrzeug(string farbe, string kennzeichen, double kilometerstand)
        {
            Farbe = farbe;
            Kennzeichen = kennzeichen;
            Kilometerstand = kilometerstand;
        }

        public abstract void Fahren(double distanz);
        public virtual void DruckeDatenblatt()
        {
            Console.WriteLine($"Farbe: {Farbe}\nKennzeichen: {Kennzeichen}\nKilometerstand: {Kilometerstand} km");
        }
    }
}