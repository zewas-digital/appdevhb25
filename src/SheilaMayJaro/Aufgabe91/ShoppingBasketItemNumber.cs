namespace Appdevhb25.SheilaMayJaro.Aufgabe91
{
    public class ShoppingBasketItemNumber
    {
        private int _amount ; 
        public int Amount
        {
            get{return _amount;}
            set{_amount = value;}
        }
        public ShoppingBasketItemNumber()
        {
            
        }
        public ShoppingBasketItemNumber(int amount)
        {
            _amount = amount; 
        }
    }
}