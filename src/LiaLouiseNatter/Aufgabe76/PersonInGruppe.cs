namespace Appdevhb25.LiaLouiseNatter.Aufgabe76
{
    public class PersonInGruppe
    {
        public int height;
        public int age;
        public string name;
        public int weight;
        private int _socialSecurityNum;
        public int socialSecurityNum
        {
            get
            {
                return _socialSecurityNum;
            }
            set
            {
                int length = Math.Abs(value).ToString().Length;
                if (length > 5)
                {
                    System.Console.WriteLine("Your social security number can only be 4 numbers.");
                }
                else
                {
                    _socialSecurityNum = value;
                }
            }
        }
        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, Height: {height} cm, Weight: {weight} kg";
        }
    }
}