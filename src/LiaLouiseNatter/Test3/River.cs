namespace Appdevhb25.LiaLouiseNatter.Test3
{
    public class River
    {
        public double Length{get; private set;}

        public string Name{get; private set;}

        public River(string name, double length)
        {
            Length = length;
            Name = name;
        }
    }
}