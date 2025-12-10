namespace Appdevhb25.NoahHois.ZooTeil3
{
    public class Tierfutter
    {
        public string Name { get; private set; }
        public string Einheit { get; private init; }
        public string Einheitspreis { get; private init; }

        public Tierfutter(string name, string einheit, string einheitspreis)
        {
            Name = name;
            Einheit = einheit;
            Einheitspreis = einheitspreis;
        }
    }
}