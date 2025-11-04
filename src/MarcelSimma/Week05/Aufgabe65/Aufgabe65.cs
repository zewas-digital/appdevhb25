using Appdevhb25.MarcelSimma.Week05.Aufgabe65;

namespace Appdevhb25.MarcelSimma.Aufgabe65
{
    public class Aufgabe65
    {
        public static void Start()
        {
            /*
            Aufgabe 65
            Erweitere deine Klasse Car so, dass es eine Methode Fahren() gibt. 
            Diese nimmt ein Argument, die Distanz, entgegen. 
            Die Methode soll den alten Kilometerstand, die Distanz und den neuen Kilometerstand auf der Konsole ausgeben. 
            Speichere ebenfalls den neuen Kilometerstand im Objekt ab. 

            */

            Car neuwagen = new Car("grün");
            Car gebrauchtwagen = new Car("rot", 1_000);
            Car vwkaefer = new Car("beige", 1_000_000);
            vwkaefer.Fahren(123.45);

            Car[] cars = new Car[2];

            cars[0] = new Car("rot");
            cars[1] = new Car("grün", 10_000);

        }
    }
}