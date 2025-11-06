namespace Appdevhb25.MarcelSimma.Week05.GetterAndSetterIntro
{
    public class GetterAndSetter
    {
        public static void Start()
        {
            Car c1 = new Car("grün", 100);
            Car c2 = new Car("grün", 100);
            Car c3 = new Car("grün", 100);
            Car c4 = new Car("grün", 100);

            // statische Attribute hole ich mir über <Klassenname>.<Feldname>
            System.Console.WriteLine(Car.AnzahlDerProduziertenAutos);

            Car.PrintAnzahlDerProduziertenAutos();

            c4.Fahren(1_000_000);
            // Ein Auto mit 1000000 am Tacho ist nichts wert.

            c4.Kilometerstand = 1000101; // Die value-Variable im Setter zeigt immer auf den Wert nach der Zuweisung.

            c4.Fahren(-100);

            System.Console.WriteLine(c4.Kilometerstand);

        }

    }
}