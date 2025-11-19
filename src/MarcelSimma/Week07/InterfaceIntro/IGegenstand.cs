public interface IGegenstand
{

    public string Inventarnummer { get; }

    // Das interface enthält nur die Methodensignatur
    public string PrintGegenstand();
}