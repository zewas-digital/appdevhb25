using Appdevhb25.KatjaHaemmerli.Aufgab88UML;

namespace Appdevhb25.KatjaHaemmerli.Aufgabe88UML
{
    public class AufgabeFahrzeuge 
    {
        /*
        - Erstelle in jeder Klasse mindestens einen Konstruktor, der mindestens einen Parameter entgegen nimmt. 
        - Überschreibe die Methode DruckeDatenblatt() aus der Superklasse. 
        - Erstelle einige Autos, Motorräder und Fahrzeuge und schau dir die Objekte im Debug-Mode an. 
          Welche Attribute/Methoden werden vererbt/geerbt?
        - Gib die Datenblätter deiner Objekte auf der Konsole aus.*/
        public static void Start()
        {
          Motorcycle1 motorrad = new Motorcycle1("Yamaha", "silber", 20_000.00, "1");
          Motorcycle1 motorrad2 = new Motorcycle1("Harley-Davidson", "schwarz", 17_000.00, "2");
          Car auto = new Car("weiss", "94.260");
          Car auto2 = new Car("weiss", "19.650");

          System.Console.WriteLine("Motorräder: ");          
          System.Console.WriteLine(); // Abstand         
          motorrad2.DruckeDatenblatt();
          System.Console.WriteLine(); // Abstand
          System.Console.WriteLine("Autos: ");          
          System.Console.WriteLine(); // Abstand          
          motorrad.DruckeDatenblatt(); 
        }
    }
}