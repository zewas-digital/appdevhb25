namespace Appdevhb25.JulianMatt.ZooBase;

public class Tier
{
    public string Name;
    public string Type;

    List<Futter> futter = new List<Futter>();

    public Tier(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public void AddFood()
    {
        System.Console.WriteLine("Welches essen nimt das Tier zu sich");
        string foodName = Console.ReadLine();
        System.Console.WriteLine("Wie viel davon");
        string foodAmount = Console.ReadLine();
        System.Console.WriteLine("Was ist der Einheitspreis");
        double foodPrice = Convert.ToDouble(Console.ReadLine());

        futter.Add(new Futter(foodName, foodAmount, foodPrice));


    }

    public List<Futter> GetFutter()
    {
        return futter;
    }

    public void DeleteFood()
    {
        futter.Clear();
    }

    public void FoodInf()
    {
        foreach( Futter f in futter)
        {
            System.Console.WriteLine($"      -Futter: {f.Name}, {f.Unit}, {f.Price}");
        }
    }
}