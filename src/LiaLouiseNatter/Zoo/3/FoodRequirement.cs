namespace Appdevhb25.LiaLouiseNatter.Zoo
{
    public class FoodRequirements
    {
        public Food Feed{get; private set;}
        public double Amount{get; private set;}
       

        public FoodRequirements(Food feed, double amount)
        {
            Feed = feed;
            Amount = amount;
            
        }
    }
}