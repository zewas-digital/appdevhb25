namespace Appdevhb25.SheilaMayJaro.AufgabeZoo
{
    public class Food
    {
        public string Name { get; private init; }
        public string Unit { get; private init; }
        public double UnitPrice { get; private init; }
        public double defaultMassSize { get; private init; } //Massengröße Defaultwert z.B. Wasser hat 1 Liter 

        public Food(string name, string unit, double unitPrice)
        {
            Name = name; 
            Unit = unit; 
            UnitPrice = unitPrice;
        }
        public void DisplayFodder()
        {
            
        }
    }
}