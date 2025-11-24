namespace Appdevhb25.JulianMatt.Aufgabe91
{
    public class Produkt
    {
        public string ChoosenProduct;


        private double _priceOfProduct;

        public double PriceOfProduct
        {
            get {return _priceOfProduct;}
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("Es gibt kein Produkt das 0 Euro Kostet");
                }
                else
                {
                    _priceOfProduct = value;
                }
            }
        }

        private int _countOfProducts;

        public int CountOfProducts
        {
            get {return _countOfProducts;}
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Es gibt kein Produkt das weniger als 0 mal vorhanden ist");
                }
                else
                {
                    _countOfProducts = value;
                }
            }
        }

        public void PrintProductInfo()
        {
            System.Console.WriteLine($"Sie haben {ChoosenProduct} ausgewählt dieses Kostet {PriceOfProduct} Euro");
        }
    }
}