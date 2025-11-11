using Appdevhb25.SheilaMayJaro.Aufgabe71;

namespace Appdevhb25.SheilaMayJaro.Aufgabe71
{
    //Motorbike ist eine erbende Klasse = Subklasse = abgeleitete Klasse
    // public class <Subklasse> : <Superklasse>
    public class Motorbike : Vehicle
    {
        //Attribute 
        public double Performance;

        public int PurchasePrice;

        public static double Sales;
        public static int NumberOfProducedMotorbikes;

        /*
       Die Attribute
         - Farbe
         - Kilometerstand
         - Kennzeichen
       sind bereits in der Superklasse Fahrzeug definiert und werden an Auto vererbt.
       Daher müssen sie hier nicht nochmals definiert werden
       */

        public Motorbike(string colour, double performance, int purchasePrice) : base(colour)
        {
            Performance = performance;
            PurchasePrice = purchasePrice;
            NumberOfProducedMotorbikes++;
            Sales += PurchasePrice;
        }
        public Motorbike()
        {
            NumberOfProducedMotorbikes++;
            Sales += PurchasePrice;
        }
        public override void PrintDataSheet()
        {
            base.PrintDataSheet();
            System.Console.WriteLine($"Leistung: {Performance}");
            System.Console.WriteLine($"Kaufpreis: {PurchasePrice}");
        }
        //wieso? - Katja gefragt, ob sie es noch weiß
        public override string ToString()
        {
            return "Das ist ein Motorrad.";
        }
        public static double CalculateAverageSalesPerMotorbike()
        {
            return Sales / NumberOfProducedMotorbikes;
        }
        public override void Driving(double distance)
        {
            Kilometrage += distance;
            System.Console.WriteLine(Kilometrage);
        }
    }
}