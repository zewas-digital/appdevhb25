namespace Appdevhb25.SheilaMayJaro.Aufgabe91
{
    public class Product
    {
        private string? _name;
        private double _price; 
        public string? Name
        {
            get{return _name;}
            set{_name = value;}
        }
        public double Price
        {
            get{return _price;}
            set{_price = value;}
        }
        public Product(string name, double price)
        {
            _name = name; 
            _price = price; 
        }
        public Product()
        {
            
        }
    }
}