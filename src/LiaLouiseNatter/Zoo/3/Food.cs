namespace Appdevhb25.LiaLouiseNatter.Zoo
{
    public class Food
    {
        public string Name{get; private set;}
        public string Unit{get; private set;}
        public double UnitPrice{get; private set;}

        public Food(string name, string unit, double unitPrice)
        {
            Name = name;
            Unit = unit;
            UnitPrice = unitPrice;
        }
    }
}