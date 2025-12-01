namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe81
{
    public class Konzert
    {
        public string KonzertName { get; set; }
        public Queue<string> Personen = new Queue<string>();

        public Konzert(string konzertName)
        {
            KonzertName = konzertName;
        }
    }
}