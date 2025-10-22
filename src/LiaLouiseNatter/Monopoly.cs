using System.Globalization;

namespace BonusAufgabeLiaMonopoly;

class Monopoly
{
    private static int totalDiceCount;
    private static int totalRoundCount;
    private static int bank = 1500;
    
    public static void Start()
    {
        MonopolyGame();
        Dicer();
    }

    public static void MonopolyGame()
    {
        bool gefaengnissFreischein = false;

        string[] alleFelder = new string[]
        {
            "LOS", "Badstraße", "Gemeinschaftsfeld", "Turmstraße", "Einkommensteuer", "Südbahnhof",
            "Chausseestraße", "Ereignisfeld", "Elisenstraße", "Poststraße", "Im Gefängnis / Nur zu Besuch",

            "Seestraße", "Elektrizitätswerk", "Hafenstraße", "Neue Straße", "Westbahnhof",
            "Münchner Straße", "Gemeinschaftsfeld", "Wiener Straße", "Berliner Straße", "Frei Parken",

            "Theaterstraße", "Museumstraße", "Ereignisfeld", "Opernplatz", "Nordbahnhof",
            "Lessingstraße", "Schillerstraße", "Wasserwerk", "Goethestraße", "Gehen Sie in das Gefängnis",

            "Rathausplatz", "Hauptstraße", "Gemeinschaftsfeld", "Bahnhofstraße", "Hauptbahnhof",
            "Ereignisfeld", "Parkstraße", "Zusatzsteuer", "Schlossallee"
        };


        int[] feldPreise = new int[]
        {
            // 0 = Los
            // 1 = Gemeinschaftsfeld
            // 2 = Ereignisfeld
            // 3 = Im gefängniss/nur zu besucht
            // 4 = Frei Parken
            // 5 = Gefängniss
            0, 60, 1, 60, 200, 200,
            100, 2, 100, 120, 3,

            140, 150, 140, 160, 200,
            180, 1, 180, 200, 4,

            220, 220, 2, 240, 200,
            260, 260, 150, 280, 5,

            300, 300, 1, 320, 200,
            2, 350, 100, 400
        };

        while (true)
        {

            totalDiceCount += Dicer();

           
            PlaceChecker(feldPreise, alleFelder, bank);

            int number = Dicer();
            EreignisFelder(bank, number, totalDiceCount, gefaengnissFreischein);



        }
    }

    public static void Shopper(string[] alleFelder, int[]feldPreise, int bank)
    {
        Console.WriteLine($"You are on: {alleFelder[totalDiceCount]}.");
        Console.WriteLine($"It would cost you: {feldPreise[totalDiceCount]}.");
        System.Console.WriteLine("You currently have: " + bank + "€");
        Console.Write("Buy" + alleFelder[totalDiceCount] + "[y/n]");
        string yesNo = Console.ReadLine();
        
        if (yesNo == "y" || yesNo == "Y")
        {
            if (bank <= feldPreise[totalDiceCount])
            {
                Console.WriteLine("You are Broke...");
            }
            else
            {
                bank -= feldPreise[totalDiceCount];
                System.Console.WriteLine(bank);
            }

        }

        if (yesNo == "N".ToUpper())
        {
            bank = bank;
        }
        


    }
    public static void PlaceChecker(int[] feldPreise, string[] alleFelder, int bank)
    {
        
        if (feldPreise[totalDiceCount] == 0)
        {
            System.Console.WriteLine("Du bist auf LOS, Kassiere einen 250€ Bonus ein :)");
            bank += 250;
        }

        if (feldPreise[totalDiceCount] == 3)
        {
            System.Console.WriteLine("Du bist auf einem Ereignissfeld");
        }
        else
        {
            Console.WriteLine($"Would you like to purchase {alleFelder[totalDiceCount]}?");
        }
    }
    
    public static void EreignisFelder(int bank, int number, int totalDiceCount, bool gefaengnissFreischein)
    {
        string[] monopolyEreigniskarten = {
        "Rücke vor bis zur Seestraße. Wenn du über Los kommst, ziehe 2045 € ein.",
        "Du hast in einem Kreuzworträtselwettbewerb gewonnen. Ziehe 1025 € ein.",
        "Miete und Anleihezinsen werden fällig. Die Bank zahlt Dir 1535 €.",
        "Du kommst aus dem Gefängnis frei.",
        "Rücke bis auf Los vor.",
        "Die Bank zahlt dir eine Dividende von 510 €.",
        "Rücke vor bis zur Schlossallee.",
        "Rücke vor bis zum Opernplatz. Wenn du über Los kommst, ziehe 2045 € ein.",
        "Gehe 3 Felder zurück.",
        "Lasse alle Deine Häuser renovieren. Zahle an die Bank für jedes Haus 255 € und für jedes Hotel 1025 €.",
        "Du wirst zu Straßenreparaturen herangezogen. Zahle 410 € für jedes Haus und 1175 € für jedes Hotel.",
        "Betrunken im Dienst. Strafe 205 €.",
        "Strafe für zu schnelles Fahren 155 €.",
        "Gehe direkt in das Gefängnis. Gehe nicht über Los. Ziehe kein Geld ein.",
        };

        if(number == 3)
        {
            Random random = new Random();
            int ereigCardNum = random.Next(0, 10);
            System.Console.WriteLine("Ziehe eine Ereigniskarte: ");
            Console.ReadKey();
            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[0])
            {
                System.Console.WriteLine(monopolyEreigniskarten[0]);
                bank += 2045; 
                totalDiceCount = 12;

            }
            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[1])
            {
                System.Console.WriteLine(monopolyEreigniskarten[1]);
                bank += 1025;
            }

            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[2])
            {
                System.Console.WriteLine(monopolyEreigniskarten[2]);
                bank += 1535;
            }
            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[3])
            {
                System.Console.WriteLine(monopolyEreigniskarten[3]);
                gefaengnissFreischein = true;
            }
            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[4])
            {
                System.Console.WriteLine(monopolyEreigniskarten[4]);
                totalDiceCount = 0;
            }
            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[5])
            {
                System.Console.WriteLine(monopolyEreigniskarten[5]);
                bank += 510;
            }
            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[6])
            {
                System.Console.WriteLine(monopolyEreigniskarten[6]);
                totalDiceCount = 40 - 1;
            }
            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[7])
            {
                System.Console.WriteLine(monopolyEreigniskarten[7]);
                totalDiceCount = 24;
                bank += 2045;
            }
            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[8])
            {
                System.Console.WriteLine(monopolyEreigniskarten[8]);
                totalDiceCount -= 3;
            }
            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[9])
            {
                System.Console.WriteLine(monopolyEreigniskarten[9]);
                System.Console.WriteLine("noch nicht implementiert");
            }
            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[10])
            {
                System.Console.WriteLine(monopolyEreigniskarten[10]);
                System.Console.WriteLine("Noch nicht implemeniert");
            }
            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[11])
            {
                System.Console.WriteLine(monopolyEreigniskarten[11]);
                bank -= 205;
            }
            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[12])
            {
                System.Console.WriteLine(monopolyEreigniskarten[12]);
                bank -= 155;
            }
             if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[12])
            {
                System.Console.WriteLine(monopolyEreigniskarten[12]);
                if (gefaengnissFreischein == true)
                {
                    System.Console.WriteLine("Du hast deinen Freischein verwendet...");
                    gefaengnissFreischein = false;
                }
                else
                {
                    totalDiceCount = 30;
                }
                
            }
        }
       
    }

    public static int Dicer()
    {
        Random random = new Random();
        Console.WriteLine("Press any key to roll the dice.");
        Console.Read();
        
        int number = random.Next(0, 7); 
        Console.WriteLine(number);
        return number;

    }
}
