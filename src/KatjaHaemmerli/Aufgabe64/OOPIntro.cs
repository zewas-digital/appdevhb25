namespace Appdevhb25.KatjaHaemmerli.Aufgab64
{
    public class OOPIntro
    {
        public static void Start()
        {

            Car.Verbrauch = 7.7;
            
            Car car = new Car();
            Car car2 = new Car();
            car.Farbe = "schwarz";
            car2.Farbe = "grün";
            car.Kennzeichen = "FK123HO";
            
            
            car.PrintCarAttribute();
            car2.PrintCarAttribute();

            car2.Farbe = "rot";
         
            Car.Verbrauch = 5.7;
            
            car2.PrintCarAttribute();

            // Hätte ich nun auch noch Objekt Moped, würde ich dieses auch in dieser Klasse erstellen
            // Moped moped = new Moped();
            // moped.Farbe = "rot";
            // jedoch seine Attribute in einem eigenen File (Mopeds)
        }
    }
}