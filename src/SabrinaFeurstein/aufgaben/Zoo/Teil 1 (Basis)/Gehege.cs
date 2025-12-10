namespace Appdevhb25.SabrinaFeurstein.aufgaben.zoo.teil1
{
    public class Gehege(string name)
    {
        public string Name { get; private set; } = name;

        public override string ToString()
        {
            return Name;
        }
    }
}