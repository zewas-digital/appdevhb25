namespace Appdevhb25.SheilaMayJaro.Aufgabe71
{
    //Vehicles ist die Basisklasse = Superklasse
    public abstract class Vehicle
    {
        /* 
        Aufbau einer Klasse
            1. Felder und Attribute mit Getter und Setter machen 
            2. Alle Konstruktoren 
        */
        //Felder sind zum Speichern 
        private string? _colour;
        //Attribute sind die Gatekeeper 
        public string Colour
        {
            get
            {
                return _colour;
            }
            //wenn die Fabe nicht veränderbar sein soll -> kein öffentlicher Setter
            //ein privater Setter, der vom Konstruktor aufgerufen werden kann
            private set
            {
                _colour = value;
            }
        }


        // public string GetColour()
        // {
        //     return _colour;
        // }
        // public void SetColour(string value)
        // {
        //     _colour = value; 
        // }

        private string _licensePlate = string.Empty;
        public string LicensePlate
        {
            get
            {
                if (_licensePlate != string.Empty)
                {
                    return _licensePlate;
                }
                else
                {
                    return "Kein Kennzeichen angegeben."; 
                }
            }
            set
            {
                if (value.Length > 2 && value.Length < 10)
                {
                    _licensePlate = value;
                }
                else
                {
                    System.Console.WriteLine("Das Kennzeichen ist zu lang oder zu kurz.");
                }
            }
        }
        private double _kilometrage;
        public double Kilometrage
        {
            get
            {  
                return _kilometrage;
            }
            set
            {
                if (value > _kilometrage)
                {
                    _kilometrage = value;
                }
                else
                {
                    System.Console.WriteLine("Der Kilometerstand darf nicht zurückgedreht werden.");
                }
            }
        }
        public static int NumberOfProducedVehicles = 0;

        //Konstruktor der Superklasse
        public Vehicle(string colour)
        {
            Colour = colour;
            Kilometrage = 0;
            LicensePlate = string.Empty;

            NumberOfProducedVehicles++;
        }
        public Vehicle()
        {

        }
        public virtual void PrintDataSheet()
        {
            System.Console.WriteLine($"Farbe: {_colour}");
            System.Console.WriteLine($"Kennzeichen: {_licensePlate}");
            System.Console.WriteLine($"Kilometerstand: {_kilometrage}");
        }
        public abstract void Driving(double distance);

    }
}