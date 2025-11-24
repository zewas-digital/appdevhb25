namespace Appdevhb25.NoahHois.Aufgabe84
{
    public class Auto : Fahrzeuge, IGegenstand
    {

        public int AmountOfDoors;
        public static int AnzahlDerProduziertenAutos;

        public string PrinzessinEihorn { get ; set ; }

        public Auto(int amountOfDoors, string color, string mark, double mileage) : base(color, mark, mileage)
        {
            AmountOfDoors = amountOfDoors;
            AnzahlDerProduziertenAutos++;
        }
        public override void PrintDataSheet()
        {
            base.PrintDataSheet();
            System.Console.WriteLine("Anzahl Türen " + AmountOfDoors);
            PrintNumberOfCarsProduced();
            System.Console.WriteLine();
        }
        public override void Drive(double distanz)
        {
            Mileage += distanz;
            System.Console.WriteLine("Neuer Kilometerstand: " + Mileage);
        }
        public void PrintNumberOfCarsProduced()
        {
            System.Console.WriteLine("Anzahl Autos " + AnzahlDerProduziertenAutos);
        }

        public string PrintObject()
        {
            return "Anzahl Türen " + AmountOfDoors + " Das ist ein Auto. Inventarnummer:" + PrinzessinEihorn;
        }
    }
}