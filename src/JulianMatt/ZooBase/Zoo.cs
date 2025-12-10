using System.ComponentModel;

namespace Appdevhb25.JulianMatt.ZooBase;

public class Zoo
{
    public string Name;

    public DateTime YearOfFoundation;

    List<Gehege> Gehege = new List<Gehege>();

    public Zoo(string name, DateTime yearOfFoundation)
    {
        Name = name;
        YearOfFoundation = yearOfFoundation;
    }

    public void GehegeInf()
    {
        System.Console.WriteLine($"Wollen sie ein oder mehrere Gehege zum Zoo {Name} hinzufügen (1) oder löschen (2)");
        string DeleteOrAdd = Console.ReadLine();

        if (DeleteOrAdd == "1")
        {
            AddGehege();
        }
        else if (DeleteOrAdd == "2")
        {
            DeleteGehege();
        }
        else
        {
            System.Console.WriteLine("Input ist invalid");
        }
        for (int i = 0; i < Gehege.Count(); i++)
        {
            System.Console.WriteLine("Wollen sie die Tiere in dem gehege managen Ja (1) oder nein (2)");
            string editAnimals = Console.ReadLine();

            if (editAnimals == "1")
            {
                System.Console.WriteLine("Welches Gehege wollen sie bearbeiten");
                string cageToEdit = Console.ReadLine();
                int cageNr = -1;
                for (int j = 0; j < Gehege.Count(); j++)
                {
                    if (Gehege[j].Name == cageToEdit)
                    {
                        cageNr = j;
                        break;
                    }
                }

                if (cageNr == -1)
                {
                    System.Console.WriteLine("Dieses Gehege gibt es nicht");
                    return;
                }

                Gehege[cageNr].GetAnimalInfo();
            }
            else if (editAnimals == "2")
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Invalider Input");
            }
        }

    }

    private void AddGehege()
    {
        System.Console.WriteLine($"Wie viele gehege wollen sie hinzufügen");
        int amountOfCages = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < amountOfCages; i++)
        {
            System.Console.WriteLine($"Wie heißt das {i + 1} gehege");
            string gehegeName = Console.ReadLine();
            Gehege.Add(new Gehege(gehegeName));
        }
    }

    private void DeleteGehege()
    {
        System.Console.WriteLine($"Wie viele Gehege wollen sie löschen");
        int amountOfCages = Convert.ToInt32(Console.ReadLine());

        if (amountOfCages > Gehege.Count())
        {
            System.Console.WriteLine("Es gibt nicht so viele Gehege");
        }

        if (Gehege.Count() == amountOfCages)
        {
            Gehege.Clear();
            return;
        }

        for (int i = 0; i < amountOfCages; i++)
        {
            System.Console.WriteLine($"Welches Gehege wollen sie löschen");
            string gehegeName = Console.ReadLine();
            for (int j = 0; j < Gehege.Count(); j++)
            {
                if (Gehege[j].Name == gehegeName)
                {
                    Gehege.RemoveAt(j);
                    break;
                }
            }
        }
    }

    public List<Futter> GetZooFutterbedarf()
    {
        List<Futter> zooFutter = new List<Futter>();

        foreach (Gehege g in Gehege)
        {
            zooFutter.AddRange(g.GetFutter());
        }

        return zooFutter;
    }

    public void PrintTagesFutterbedarf()
    {
        List<Futter> futterbedarf = GetZooFutterbedarf();
        double gesamtKosten = 0;

        System.Console.WriteLine("Futterbedarf");
        System.Console.WriteLine("----------------------------------");

        foreach (Futter f in futterbedarf)
        {
            System.Console.WriteLine($"{f.Name,-10} {f.Unit,-15} {f.Price,8:0.00} €");

            gesamtKosten += f.Price;
        }

        System.Console.WriteLine("----------------------------------");
        System.Console.WriteLine($"{"Summe",-25} {gesamtKosten,8:0.00} €");
    }




    public void PrintZooInfo()
    {
        System.Console.WriteLine($"Zoo: {Name}, gegründet {YearOfFoundation.Year}");
        foreach (Gehege g in Gehege)
        {
            System.Console.WriteLine($"-Gehege: {g.Name}");
            g.AnimalInfo();
        }
        System.Console.WriteLine("\n");
        PrintTagesFutterbedarf();


    }
}