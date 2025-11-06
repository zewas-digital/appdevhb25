namespace Appdevhb25.KatjaHaemmerli.Aufgab65
{
    public class OOPIntro2
    {
        public static void Start()
        {
            Car car = new Car();
            car.Farbe = "schwarz";
            car.Kennzeichen = "FK123HO";
            car.Verbrauch = 7.7;
            car.Distanz = 50;
            // car.AlterKilometerstand = 123567;
            // car.NeuerKilometerstand = 12345678;
            car.Kilometerstand = 123567;
            car.PrintCarAttribute();
            car.Fahren();            
        }
    }
}