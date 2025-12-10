namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class Food
    {
        public string Name { get; private init; }
        public string Unit { get; private init; }
        public double UnitPrice { get; private init; }
        public Food(string name, string unit, double unitPrice)
        {
            Name = name; 
            Unit = unit; 
            UnitPrice = unitPrice;
        }
    }
}