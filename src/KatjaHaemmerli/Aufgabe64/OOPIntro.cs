namespace Appdevhb25.KatjaHaemmerli.Aufgab64
{
    public class OOPIntro
    {
        public static void Start()
        {

            Car.Verbrauch = 7.7;

            Car car = new Car("schwarz", 1234);            

            car.PrintCarAttribute();

            Car car2 = new Car("grün", 4321);
            car.Kennzeichen = "FK123HO";
            // car.seriennummer = 127389213; // kann im Nachhinein nicht verändert werden da auf privat gesetzt
            
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