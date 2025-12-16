namespace Appdevhb25.LauraKatharinaBertsch.ZooTeil4
{
    public class Food
    {
        public string FoodName { get; private set; }
        public decimal AmountPerFood { get; private set; }
        public decimal Price { get; private set; }

        public static decimal price = 0;
        public Food(string foodName, decimal amountPerFood, decimal price)
        {
            FoodName = foodName;
            AmountPerFood = amountPerFood;
            Price = price;
        }
        public override string ToString()
        {
            return $"{FoodName}   {AmountPerFood}     {Price} €";
        }
    }
}