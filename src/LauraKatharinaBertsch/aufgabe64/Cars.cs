namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe64
{
    public class Car()
    {
        public string Farbe;
        public string Kennzeichen;
        public int Verbrauch;

        private double _kilometerstand;

        public double Kilometerstand
        {
            get
            {
                return _kilometerstand;
            }
            set
            {
                if (value > _kilometerstand)
                {
                    _kilometerstand = value;
                }
                else
                {
                    Console.WriteLine("Der Kilometerstand darf nicht kleiner werden.");
                }
            }
        }

        public void PrintCar()
        {
            Console.WriteLine("Mein Auto:");
            Console.WriteLine("Farbe: " + Farbe);
            Console.WriteLine("Kilometerstand: " + Kilometerstand);
            Console.WriteLine("Kennzeichen: " + Kennzeichen);
            Console.WriteLine("Verbrauch: " + Verbrauch);
        }


    }
}