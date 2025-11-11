namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe64
{
    public class Intro
    {
        public static void Start()
        {
            Car myCar = new Car();
            myCar.Farbe = "blau";
            myCar.Kilometerstand = 12345;
            myCar.Kennzeichen = "AT-a123";
            myCar.Verbrauch = 5;

            myCar.PrintCar();
        }
    }
}