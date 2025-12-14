namespace Appdevhb25.MarcelSimma.Week08
{
    public class Hund : Tier
    {
        public string Rasse { get; set; }

        public Hund(string name, int alter, string rasse) : base(name, alter)
        {
            Rasse = rasse;
        }

        public void Bellen()
        {
            Console.WriteLine("Der Hund " + Name + " Wuff Wuff!");
        }
    }
}