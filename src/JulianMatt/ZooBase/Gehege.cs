namespace Appdevhb25.JulianMatt.ZooBase;

public class Gehege
{
    public string Name;

    List<Tier> tier = new List<Tier>();


    public Gehege(string name)
    {
        Name = name;
    }

    public void GetAnimalInfo()
    {
        System.Console.WriteLine($"Wollen sie ein oder mehrere Tiere zum Gehege {Name} hinzufügen (1) oder löschen (2)");
        string DeleteOrAdd = Console.ReadLine();

        if (DeleteOrAdd == "1")
        {
            AddTier();
        }
        else if (DeleteOrAdd == "2")
        {
            DeleteTier();
        }
        else
        {
            System.Console.WriteLine("Input ist invalid");
        }
    }

    private void AddTier()
    {
        System.Console.WriteLine($"Wie viele Tiere wollen sie hinzufügen");
        int amountOfCages = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < amountOfCages; i++)
        {
            System.Console.WriteLine($"Wie heißt das {i+1} Tier");
            string TierName = Console.ReadLine();
            System.Console.WriteLine($"Was für eine Raße hat es");
            string TierType = Console.ReadLine();
            tier.Add(new Tier(TierName, TierType));
            tier[i].AddFood();
        }
    }

    private void DeleteTier()
    {
        System.Console.WriteLine($"Wie viele Tiere wollen sie löschen");
        int amountOfAnimals = Convert.ToInt32(Console.ReadLine());

        if (amountOfAnimals > tier.Count())
        {
            System.Console.WriteLine("Es gibt nicht so viele Tiere");
        }

        if (tier.Count() == amountOfAnimals)
        {
            tier.Clear();
            return;
        }

        for(int i = 0; i < amountOfAnimals; i++)
        {
            System.Console.WriteLine($"Welches Tier wollen sie löschen");
            string animalName = Console.ReadLine();
            for (int j = 0; j < tier.Count(); j++)
            {
                if (tier[j].Name == animalName)
                {
                    tier[j].DeleteFood();
                    tier.RemoveAt(j);
                    break;
                }
            }
        }
    }

    public List<Futter> GetFutter()
    {
        List<Futter> allFutter = new List<Futter>();

        foreach (Tier t in tier)
        {
            allFutter.AddRange(t.GetFutter());
        }

        return allFutter;
    }

    public void AnimalInfo()
    {
        foreach(Tier t in tier)
        {
            System.Console.WriteLine($"   -Tier: {t.Name}, {t.Type}");
            t.FoodInf();
        }
    }
}