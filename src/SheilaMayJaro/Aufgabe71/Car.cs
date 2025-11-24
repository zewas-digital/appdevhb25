using Appdevhb25.SheilaMayJaro.Aufgabe71;

namespace Appdevhb25.SheilaMayJaro.Aufgabe71
{   //Car ist eine erbende Klasse = Subklasse = abgeleitete Klasse
    // public class <Subklasse> : <Superklasse>
    public class Car : Vehicle
    {
        //Attribute
        private int _numberOfDoors;
        public int NumberOfDoors
        {
            get{return _numberOfDoors;}
            set{_numberOfDoors = value;}
        }
        public static int NumberOfProducedCars = 0;

        /*
       Die Attribute
         - Farbe
         - Kilometerstand
         - Kennzeichen
       sind bereits in der Superklasse Fahrzeug definiert und werden an Auto vererbt.
       Daher müssen sie hier nicht nochmals definiert werden
       */

        //base() ruft den Konstruktor der Superklasse auf 
        //Die Argeumente, welche in der Superklasse definiert werden, müssen an base() übergeben werden 
        public Car(string colour, int numberOfDoors) : base(colour)
        {
            _numberOfDoors = numberOfDoors;
            NumberOfProducedVehicles++;
            NumberOfProducedCars++;
        }
        public Car()
        {
        }
        public override void Driving(double distance)
        {
            Kilometrage += distance;
            System.Console.WriteLine(Kilometrage);

        }
        public override void PrintDataSheet()
        {
            base.PrintDataSheet();
            System.Console.WriteLine($"Das Auto hat {_numberOfDoors} Türen.");
        }
      public override string ToString()
        {
            return "Das ist ein Auto.";
        }
    }
}