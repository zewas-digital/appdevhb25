namespace Appdevhb25.NoahHois.Aufgabe84
{
    public class Motorrad : Fahrzeuge, IGegenstand
    {

        public double Horsepower;
        public double PurchasePrice;
        public static double SalesVolume;
        public static int AnzahlDerProduziertenMotorraeder;

        public string PrinzessinEihorn { get ; set ; }

        public Motorrad(double horsepower, double purchasePrice, string color, string mark, double mileage) : base(color, mark, mileage)
        {
            Horsepower = horsepower;
            PurchasePrice = purchasePrice;
            SalesVolume += PurchasePrice;
            AnzahlDerProduziertenMotorraeder++;
        }
        public override void PrintDataSheet()
        {
            base.PrintDataSheet();
            System.Console.WriteLine("PS " + Horsepower);
            System.Console.WriteLine("Kaufpreis " + PurchasePrice);
            System.Console.WriteLine("Durchschnitt: " + CalculateAverageRevenue());
            System.Console.WriteLine();
        }
        public static double CalculateAverageRevenue()
        {
            return SalesVolume / AnzahlDerProduziertenMotorraeder;
        }
        public override void Drive(double distanz)
        {
            Mileage += distanz;
            System.Console.WriteLine("Neuer Kilometerstand: " + Mileage);
        }

        public string PrintObject()
        {
            return "Kaufpreis " + PurchasePrice + " Das ist ein Motorrad. Inventarnummer:" + PrinzessinEihorn;
        }
    }
}