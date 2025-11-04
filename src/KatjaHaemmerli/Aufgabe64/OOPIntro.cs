namespace Appdevhb25.KatjaHaemmerli.Aufgab64
{
    public class OOPIntro
    {
        public static void Start()
        {
            Car car = new Car();
            car.Farbe = "schwarz";
            car.Kennzeichen = "FK123HO";
            car.Verbrauch = 7.7;
            car.PrintCarAttribute();
            
            // Hätte ich nun auch noch Objekt Moped, würde ich dieses auch in dieser Klasse erstellen
            // Moped moped = new Moped();
            // moped.Farbe = "rot";
            // jedoch seine Attribute in einem eigenen File (Mopeds)
        }
    }
}