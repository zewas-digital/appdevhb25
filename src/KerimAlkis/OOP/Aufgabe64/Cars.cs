namespace Appdevhb25.KerimAlkis.Aufgabe64
{
    public class Cars
    {
        public static void Start()
        {
            Car c1 = new Car("grün", 5000, "ABC123", 7.5);
            Car c2 = new Car("blau", 10000, "Ker555", 8);
            c1.PrintCar();
            c1.Fahren();
            c1.PrintCar();

            //c2.PrintCar();

        }
    }

    public class Car
    {
        public string Farbe;
        public double Kilometerstand;
        public string Kennzeichen;
        public double Verbrauch;

        public Car(string farbe, double kilometerstand, string kennzeichen, double verbrauch)
        {
            this.Farbe = farbe;
            this.Kilometerstand = kilometerstand;
            this.Kennzeichen = kennzeichen;
            this.Verbrauch = verbrauch;
        }



        public void PrintCar()
        {
            System.Console.WriteLine($"Farbe: {Farbe}, Kilometerstand: {Kilometerstand}, Kennzeichen: {Kennzeichen}; Verbrauch: {Verbrauch}");
        }

        public void Fahren()
        {
            Console.WriteLine("Gib die gefahrene Distanz ein: ");
            double distanz = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine($"alter Kilometerstand: {Kilometerstand}, Distanz: {distanz}, neuer Kilometerstand: {Kilometerstand + distanz}");
            this.Kilometerstand += distanz;
        }
    }
}