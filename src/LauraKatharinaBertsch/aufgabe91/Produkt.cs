using System.Buffers.Binary;
using Appdevhb25.LauraKatharinaBertsch.Aufgabe13;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe91
{
    public class Product
    {
        public string Name;
        public decimal Price;

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}