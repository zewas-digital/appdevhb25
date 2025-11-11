using System;
using Appdevhb25.SheilaMayJaro.Aufgabe64and65;
namespace Appdevhb25.SheilaMayJaro.Aufgabe64And65
{
    public class Cars
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 64)");

            /*
            Erstelle eine Klasse "Car". 
            Speichere zu deinem Auto die Attribute Farbe, Kilometerstand, Kennzeichen und Verbrauch. 
            Erstelle eine Methode PrintCar() mit der du alle Informationen, die du zum Auto gespeichert hast, auf der Konsole ausgibst. 
            */

            Car myCar = new Car();
            myCar.Colour = "blau";
            myCar.LicensePlate = "B 333EP";
            myCar.Kilometrage = 123_456;
            myCar.FuelConsumption = 7.7;
            myCar.PrintCar();

            System.Console.WriteLine("Aufgabe 65)");
            /*
            Erweitere deine Klasse Car so, dass es eine Methode Fahren() gibt. Diese nimmt ein Argument, die Distanz, entgegen. 
            Die Methode soll den alten Kilometerstand, die Distanz und den neuen Kilometerstand auf der Konsole ausgeben. 
            Speichere ebenfalls den neuen Kilometerstand im Objekt ab. 
            */
            int distance = 240;
            myCar.Driving(distance);
        }
    }
}