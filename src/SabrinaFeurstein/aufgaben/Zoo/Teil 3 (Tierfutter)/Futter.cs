namespace Appdevhb25.SabrinaFeurstein.aufgaben.zoo.teil3
{
    public class Futter(string name, string einheit, double einheitspreis)
    {
        public string Name { get; private set; } = name;
        public string Einheit { get; private set; } = einheit;
        public double Einheitspreis { get; private set; } = einheitspreis;
    }
}