namespace Appdevhb25.MarcelSimma.Week05.VererbungIntro
{
    // Fahrzeug ist die Basisklasse = Superklasse = Elternklasse = vererbende Klasse
    public abstract class Fahrzeug
    {
        // aus einer abstrakten Klasse können keine Objekte generiert werden. 

        /*
        Aufbau einer Klasse
          1. Felder und Attribute mit Getter und Setter
          2. Alle Konstruktoren


        */

        // Felder sind zum Speichern
        private string _farbe;

        // Attribute sind die Gatekeeper
        public string Farbe
        {
            get
            {
                return _farbe;
            }
            // kein öffentlicher Setter, wenn die Farbe nicht veränderbar sein soll.
            // ein privater Setter, der vom Konstruktor aufgerufen werden kann. 
            private set
            {
                _farbe = value;
            }
        }

        public string _kennzeichen = "";
        public string Kennzeichen
        {
            get
            {
                return _kennzeichen;
            }
            set
            {
                if (value.Length > 2 && value.Length < 10)
                {
                    _kennzeichen = value;
                }
                else
                {
                    System.Console.WriteLine("Das Kennzeichen ist zu lang oder zu kurz.");
                }
            }
            // kein Setter, wenn die Farbe nicht veränderbar sein soll.
        }

        private double _kilometerstand = 0;


        // Standardwerte
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
                    System.Console.WriteLine("Kilometerstand darf nicht zurückgedreht werden.");
                }
            }
        }

        public static int AnzahlDerProduziertenFahrzeuge = 0;

        // Konstruktor der Superklasse
        public Fahrzeug(string farbe)
        {
            Farbe = farbe;
            Kilometerstand = 0;
            Kennzeichen = "";

            AnzahlDerProduziertenFahrzeuge++;
        }

        public Fahrzeug ()
        {
            
        }

        public virtual void DruckeDatenblatt()
        {
            System.Console.WriteLine("Farbe: " + Farbe);
            System.Console.WriteLine("Kennzeichen: " + Kennzeichen);
            System.Console.WriteLine("Kilometerstand: " + Kilometerstand);

        }

        public abstract void Fahren(double distance);

    }
}