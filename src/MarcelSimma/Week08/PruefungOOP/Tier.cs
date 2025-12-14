namespace Appdevhb25.MarcelSimma.Week08
{

    public class Tier
    {
        public string Name { get; set; }
        private int _alter;
        public int Alter
        {
            get { return _alter; }
            set
            {
                if (value > 0)
                {
                    _alter = value;
                }
                else
                {
                    _alter = 0;
                }
            }
        }

        public Tier(string name, int alter)
        {
            Name = name;
            Alter = alter;
        }
    }
}