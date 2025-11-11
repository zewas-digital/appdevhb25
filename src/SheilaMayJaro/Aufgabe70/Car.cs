using Appdevhb25.SheilaMayJaro.Aufgabe70;

namespace Appdevhb25.SheilaMayJaro.Aufgabe70
{   //Car ist eine erbende Klasse = Subklasse = abgeleitete Klasse
    // public class <Subklasse> : <Superklasse>
    public class Car : Vehicle
    {
        //Attribute
        private int _numberOfDoors;
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
        public override void PrintDataSheet()
        {
            base.PrintDataSheet();
            System.Console.WriteLine($"Das Auto hat {_numberOfDoors} Türen.");
        }

    }
}