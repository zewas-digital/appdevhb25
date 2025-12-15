namespace Appdevhb25.JulianMatt.ZooBase4;

public class Pfleger
{
    public string Name;
    List<Gehege> geheges = new List<Gehege>();

    public Pfleger(string name)
    {
        Name = name;
    }
}