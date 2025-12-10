namespace Appdevhb25.JulianMatt.ZooBase4;

public class Main
{

    public static void StartZ1()
    {
        bool whatNow = false;

        List<Zoo> zoos = new List<Zoo>();

        zoos.Add(new Zoo("Tiergarten Dornbirn", new DateTime(2000, 03, 04)));
        zoos.Add(new Zoo("Zoo Zürich", new DateTime(1925, 05, 12)));
        zoos.Add(new Zoo("Zoo Basel", new DateTime(1874, 07, 25)));

        while (whatNow == false)
        {
            System.Console.WriteLine("Möchten sie ihre bestehenden Zoos anzeigen lassen(1) oder die Gehege der Zoos bearbeiten(2)");
            string whatToDo = Console.ReadLine();

            if (whatToDo == "1")
            {
                foreach (Zoo z in zoos)
                {
                    z.PrintZooInfo();
                }
            }

            else if (whatToDo == "2")
            {
                System.Console.WriteLine("Welcher Zoo:");
                string choosenZoo = Console.ReadLine();
                int ZooNr = -1;
                for (int j = 0; j < zoos.Count(); j++)
                {
                    if (zoos[j].Name == choosenZoo)
                    {
                        ZooNr = j;
                        break;
                    }
                }

                if (ZooNr == -1)
                {
                    System.Console.WriteLine("Diesen Zoo gibts es nicht");
                }

                zoos[ZooNr].GehegeInf();


            }
            else
            {
                System.Console.WriteLine("Invalider Input");
            }

            whatNow = DoYouWantToStop();
        }
    }

    public static bool DoYouWantToStop()
    {
        bool whatNow = false;

        System.Console.WriteLine("Willst du das Programm beenden Ja (1) Nein (2)");
        string answer = Console.ReadLine();

        if (answer == "1" || answer == "Ja")
        {
            whatNow = true;
        }
        else if (answer == "2" || answer == "Nein")
        {
            whatNow = false;
        }
        return whatNow;
    }
}

