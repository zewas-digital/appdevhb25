namespace Appdevhb25.MarcelSimma.Week05.GetterAndSetterIntro
{
    public class Car
    {
        /*
        Aufgabe 1:
        Speichere dir die Anzahl der produzierten Autos.
        Erstelle eine Methode, welche die Anzahl der produzierten Autos ausgibt.
        */

        public static int AnzahlDerProduziertenAutos = 0;


        /*
        Aufgabe 2:
        Erstelle sinnvolle Getter und Setter, um den Zugriff auf deine Attribute zu steuern. 
        Attribute werden als Gatekeeper verwendet, um die Felder vor unberichtigtem Zugriff oder der Zuweisung von falschen Werten zu schützen.

        Mit einem Getter kann ich auf ein Feld zugreifen. Gleichzeitig kann ich prüfen, wer zugreifen darf.
        Mit einem Setter kann ich ein Feld bearbeiten. Bevor ich den neuen Wert speichere, kann ich diesen validieren.
        */

        // privates Feld, welches den Wert speichert
        private double _kilometerstand; 

        // öffentliches Instanzattribut, das als Gatekeepter agiert
        public double Kilometerstand
        {
            get
            {
                // Der Getter gibt den im privaten Feld gespeicherten Wert zurück.
                return _kilometerstand;
            }
            
            set
            {
                /*
                Aufruf in GetterAndSetter.cs:

                c4.Kilometerstand = -100; 
                                      |
                                      |
                                      V
                                Der value-Bezeichner im Setter zeigt immer auf den Wert nach der Zuweisung beim Aufruf eines Attributes.
                                      |
                      +---------------+
                      |
                      V                      */
                if (value > _kilometerstand)
                {
                    _kilometerstand = value;
                } else
                {
                    System.Console.WriteLine("Kilometerstand darf nicht zurückgedreht werden.");
                }
            }
        }

        public string Farbe;

        public Car(string farbe) {
            Farbe = farbe;
            AnzahlDerProduziertenAutos++;
        }

        public Car(string farbe, double kilometerstand)
        {
            Farbe = farbe;
            Kilometerstand = kilometerstand;
            AnzahlDerProduziertenAutos += 1;
        }

        public void Fahren(double distanz)
        {
            System.Console.WriteLine("Alter Stand: " + Kilometerstand);
            System.Console.WriteLine("Distanz: " + distanz);
            // In Instanzmethoden greifen wir ebenfalls über das Instanzattribut, nicht das private Feld zu.
            // Sonst würden wir die hinterlegten Validierungen umgehen.
            Kilometerstand += distanz;
            System.Console.WriteLine("Neuer Stand: " + Kilometerstand);
        }

        // Klassenmethode zu Aufgabe 1
        public static void PrintAnzahlDerProduziertenAutos()
        {
            System.Console.WriteLine("Es wurden " + AnzahlDerProduziertenAutos + " Autos produziert.");
        }
    }
}