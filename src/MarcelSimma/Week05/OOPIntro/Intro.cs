using System.Runtime.CompilerServices;

namespace Appdevhb25.MarcelSimma.OOPIntro
{
    public class Intro
    {
        public static void Start()
        {

            // Aufgabe: Autoverwaltung

            // Auto von Kerim
            int anzahlDerTueren0 = 5;
            double gewicht0 = 2500;
            string marke0 = "Porsche";
            int ps0 = 761;
            double kilometerstand0 = 2_000_000;

            // Motorrad von Jona
            int anzahlDerTueren1 = 0;
            double gewicht1 = 250; // kg
            string marke1 = "Yamaha";
            int ps1 = 70;
            double kilometerstand1 = 2_000_000;

            // --> Für jedes weitere Gefährt müssten wir wieder alle Variablen erstellen. Das ist laut Jona richtigerweise verwirrend. 
            // Alternativ könnten wir für jede Eigenschaft ein eigenes Array erstellen. 

            int[] anzahlDerTuerenArray = new int[] { 5, 0 };
            double[] gewichtArray = new double[] { 2500, 250 };
            string[] markenArray = new string[] { "Porsche", "Yamaha" };
            int[] psArray = new int[] { 2_000_000, 5 };

            // --> Das ist auch unübersichtlich, verwirrend und birgt großes Fehlerpotenzial.


            // Um dieses Problem zu beheben wurde die Objektorientierung eingeführt.
            // Ziel der OOP ist es die Zusammenhänge der Wirklichkeit auch in der Softwareentwicklung abzubilden. 
            // Weitere Infos zu Klassen, Objekten und Konstruktoren im Theorie-Channel im Teams.

            // Ein neues Objekt von Typ Car erstellen
            Car c0 = new Car(); 
            /*
             |  |   |   |
             |  |   |   |
             |  |   |   Car(): Konstruktor; wenn ich ein Objekt erstellen will, rufe ich den Konstruktor auf
             |  |   |   
             |  |   = new: Es wird ein Objekt und keine normale Variable erzeugt.
             |  |
             |  c: Name des Objektes = Name der Instanz
             |  
            Car: Klassenname = Datentyp

            Mit dem Standardkonstruktor Car() wird ein leeres Objekt erstellt. Das heißt, die Felder werden leer oder mit den hinterlegten Standardwerten erstellt. 

            Wenn ich Instanzattribut aufrufen oder bearbeiten will, mache ich das über den <Namen der Instanz><Punkt><Name des Attributes>.
            */

            c0.Farbe = "rot";

            Console.WriteLine("Das Auto ist " + c0.Farbe);

            c0.PrintColor();

            System.Console.WriteLine(new string('-', 20));

            Car c1 = new Car();
            c1.Farbe = "grün";
            c1.PrintColor();

            System.Console.WriteLine(new string('-', 20));

            // Objekte können wir primitive Datentypen in Arrays verwendet und verarbeitet werden. 
            int[] zahlen = new int[3];
            Car[] cars = new Car[3];

            cars[0] = new Car();
            cars[0].Farbe = "gelb";
            cars[1] = new Car();
            cars[1].Farbe = "schwarz";
            cars[2] = new Car();
            cars[2].Farbe = "orange";


            for (int i = 0; i < cars.Length; i++)
            {
                System.Console.WriteLine(cars[i].Farbe);
            }

            System.Console.WriteLine(new string('-', 20));

            foreach (Car car in cars)
            {
                System.Console.WriteLine(car.Farbe);
            }     
        }
    }
}