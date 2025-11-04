namespace Appdevhb25.MarcelSimma.Week05.Aufgabe65
{
    public class Car
    {
        /*
        Aufbau einer Klasse
        1. alle Attribute
        2. alle Konstruktoren
        3. Methoden

        1. Attribute
        */
        public double Kilometerstand;
        public string Farbe;


        // 2. Konstruktoren

        // Konstruktoren können genau so wie Methoden überladen werden. 
        // Darum können mehrere Konstuktoren mit demselben Namen in derselben Klasse existieren.
        // Die Konstruktoren müssen sich in der Anzahl, in der Reihenfolge und in den Datentypen der Parameter unterscheiden.
    

        // eignet sich für Neuwagen
        public Car(string farbe) // Ich erzwinge, dass alle Attribute beim Aufruf des Konstruktors definiert werden müssen
        {
            Farbe = farbe;
            Kilometerstand = 0; // Bei einem Neuwagen ist der Kilometerstand standardmäßig 0.
        }

        // eignet sich für Gebrauchtwagen
        public Car(string farbe, double kilometerstand)
        {
            Farbe = farbe;
            Kilometerstand = kilometerstand;
        }
        

        // 3. Methoden
        public void Fahren(double distanz)
        {
            System.Console.WriteLine("Alter Stand: " + Kilometerstand);
            System.Console.WriteLine("Distanz: " + distanz);
            Kilometerstand += distanz;
            System.Console.WriteLine("Neuer Stand: " + Kilometerstand);

        }
    }
}