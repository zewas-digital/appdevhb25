using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe70
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
          Motorrad motorrad = new Motorrad("Yamaha", "silber", 20_000);
          Motorrad motorrad2 = new Motorrad("Harley-Davidson", "schwarz", 17_000);
          Auto auto = new Auto("Fiat", "weiss", 94.260);
          Auto auto2 = new Auto("Seat", "weiss", 19.650);

          System.Console.WriteLine("Motorräder: ");          
          System.Console.WriteLine(); // Abstand         
          motorrad2.DruckeDatenblatt();
          System.Console.WriteLine(); // Abstand
          System.Console.WriteLine("Autos: ");          
          System.Console.WriteLine(); // Abstand          
          auto2.DruckeDatenblatt(); 

        }
    }
}