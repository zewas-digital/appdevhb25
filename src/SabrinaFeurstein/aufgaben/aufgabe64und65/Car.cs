namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe64und65
{
    public class Car
    {
        public string Farbe;
        public double Kilometerstand;
        public string Kennzeichen;
        public double Verbrauch;

        public Car(string farbe, double kilometerstand, string kennzeichen, double verbrauch)
        {
            Farbe = farbe;
            Kilometerstand = kilometerstand;
            Kennzeichen = kennzeichen;
            Verbrauch = verbrauch;

        }

        public void PrintCar()
        {
            Console.WriteLine($"{Farbe} - {Kilometerstand:F2} km - {Kennzeichen} - {Verbrauch:F2} L/100");
        }

        public void Fahren(double distanz)
        {
            double kilometerstandNeu = Kilometerstand + distanz;
            Console.WriteLine($"alter Kilometerstand: {Kilometerstand} km, Distanz: {distanz} km, neuer Kilometerstand: {kilometerstandNeu} km");
            Kilometerstand = kilometerstandNeu;
        }
    }
}