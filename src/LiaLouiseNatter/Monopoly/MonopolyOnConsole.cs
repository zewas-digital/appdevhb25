namespace Appdevhb25.LiaLouiseNatter.Monopoly;

public static class MonopolyOnConsole
{
    private static int totalDiceCount;
    private static int bank;
    private static int[] boughtGround = new int[40];


    public static void MonopolyStart()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.White;
        Monopoly();
    }

    public static int Player()
    {

        int maxPlayers;
        System.Console.WriteLine("Wiviele Spieler? [2-8] ");
        while (!int.TryParse(Console.ReadLine(), out maxPlayers))
        {
            System.Console.WriteLine("Nur Zahlen Erlaubt!!!!!");
        }

        return maxPlayers;


    }

    public static void Monopoly()
    {
        System.Console.WriteLine("TESTOBEN");
        bank = 1500;
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
            0, 60, 0, 60, 200, 200,
            100, 0, 100, 120, 0,

            140, 150, 140, 160, 200,
            180, 0, 180, 200, 0,

            220, 220, 0, 240, 200,
            260, 260, 150, 280, 0,

            300, 300, 0, 320, 200,
            0, 350, 100, 400
        };

        string[] DiceFaces = new string[]
        {
            // Würfel 1
            "+-------+",
            "|       |",
            "|   o   |",
            "|       |",
            "+-------+",

            // Würfel 2
            "+-------+",
            "| o     |",
            "|       |",
            "|     o |",
            "+-------+",

            // Würfel 3
            "+-------+",
            "| o     |",
            "|   o   |",
            "|     o |",
            "+-------+",

            // Würfel 4
            "+-------+",
            "| o   o |",
            "|       |",
            "| o   o |",
            "+-------+",

            // Würfel 5
            "+-------+",
            "| o   o |",
            "|   o   |",
            "| o   o |",
            "+-------+",

            // Würfel 6
            "+-------+",
            "| o   o |",
            "| o   o |",
            "| o   o |",
            "+-------+"
        };

        string[] gameBoard = new string[]
        {

            "+----------------------------------------------------------------------------------------------------------------------------------------------------------+",
            "|Frei Parken|Theaterstraße|Museumstraße|Ereignisfeld|Opernplatz|Nordbahnhof|Lessingstraße|Schillerstraße|Wasserwerk|Goethestraße|Gehen Sie in das Gefängnis|",
            "|           |     220     |    220     |            |    240   |     200   |      260    |     260      |    150   |    280     |                          |",
            "+----------------------------------------------------------------------------------------------------------------------------------------------------------+",
            "|  Berliner Straße |                                                                                                                    |   Rathausplatz   |",
            "|      280         |                                                                                                                    |      280         |",
            "|------------------|                                                                                                                    |------------------|",
            "|   Wiener Straße  |                                                                                                                    |    Hauptstraße   |",
            "|      180         |                                                                                                                    |       280        |",
            "|------------------|                                                                                                                    |------------------|",
            "|Gemeinschaftsfeld |          ▄▄▄▄███▄▄▄▄    ▄██████▄  ███▄▄▄▄    ▄██████▄     ▄███████▄  ▄██████▄      ▄█       ▄██   ▄                |Gemeinschaftsfeld |",
            "|                  |          ▄██▀▀▀███▀▀▀██▄ ███    ███ ███▀▀▀██▄ ███    ███   ███    ███ ███    ███  ███       ███   ██▄              |      280         |",
            "|------------------|          ███   ███   ███ ███    ███ ███   ███ ███    ███   ███    ███ ███    ███  ███       ███▄▄▄███              |------------------|",
            "|  Münchner Straße |          ███   ███   ███ ███    ███ ███   ███ ███    ███   ███    ███ ███    ███  ███       ▀▀▀▀▀▀███              |   Bahnhofstraße  |",
            "|      100         |          ███   ███   ███ ███    ███ ███   ███ ███    ███ ▀█████████▀  ███    ███  ███       ▄██   ███              |      280         |",
            "|------------------|          ███   ███   ███ ███    ███ ███   ███ ███    ███   ███        ███    ███  ███       ███   ███              |------------------|",
            "|   Westbahnhof    |          ███   ███   ███ ███    ███ ███   ███ ███    ███   ███        ███    ███  ███▌    ▄ ███   ███              |   Hauptbahnhof   |",
            "|      200         |           ▀█   ███   █▀   ▀██████▀   ▀█   █▀   ▀██████▀   ▄████▀       ▀██████▀   █████▄▄██  ▀█████▀               |      280         |",
            "|------------------|                                                                                                                    |------------------|",
            "|   Neue Straße    |                                                                                                                    |   Ereignisfeld   |",
            "|      160         |                                                                                                                    |      280         |",
            "|------------------|                                                                                                                    |------------------|",
            "|Hafenstraße       |                                                                                                                    |     Parkstraße   |",
            "|      140         |                                                                                                                    |      280         |",
            "|------------------|                                                                                                                    |------------------|",
            "|Elektrizitätswerk |                                                                                                                    |    Zusatzsteuer  |",
            "|      150         |                                                                                                                    |      280         |",
            "|------------------|                                                                                                                    |------------------|",
            "|    Seestraße     |                                                                                                                    |   Schlossallee   |",
            "|      140         |                                                                                                                    |      280         |",
            "+----------------------------------------------------------------------------------------------------------------------------------------------------------+",
            "|Im Gefängnis / Nur zu Besuch|Poststraße|Elisenstraße|Ereignisfeld|Chausseestraße|Südbahnhof|Einkommensteuer|Turmstraße|Gemeinschaftsfeld|Badstraße|  LOS  |",
            "|                            |    120   |    100     |            |     100      |   200    |      200      |    60    |                 |   60    |       |",
            "+----------------------------------------------------------------------------------------------------------------------------------------------------------+",
        };
        bool gefaengnissFreischein = false;
        int maxPlayers = Player();
        int currentPlayer = 1;
        while (true)
        {
            System.Console.WriteLine($"Spieler {currentPlayer} ist an der Reihe!");
            if (currentPlayer >= maxPlayers)
            {
                currentPlayer = 1;
            }
            else
            {
                currentPlayer++; 
                
            }
            System.Console.WriteLine();
            int number = Dicer(DiceFaces);
            totalDiceCount += number;
            totalDiceCount %= alleFelder.Length;
            Console.Clear();
            boardDrawer(gameBoard, alleFelder, currentPlayer, feldPreise, boughtGround);

            System.Console.WriteLine();
            System.Console.WriteLine("Du hast Gewürfelt:");
            DrawDice(number, DiceFaces);


            System.Console.WriteLine("-------------------------------");

            if (feldPreise[totalDiceCount] > 0)
            {
                Console.WriteLine($"Du stehst auf: {alleFelder[totalDiceCount]}.");
                Console.WriteLine($"{alleFelder[totalDiceCount]} kostet: {feldPreise[totalDiceCount]}");
                System.Console.WriteLine($"Du hast: {bank}");
                Buyer(feldPreise, totalDiceCount, alleFelder, currentPlayer, boughtGround);
            }

            else
            {
                System.Console.WriteLine($"Du stehst auf: {alleFelder[totalDiceCount]}");
            }
            EreignisFelder(number, totalDiceCount, gefaengnissFreischein, alleFelder);
        }
    }
    public static string Buyer(int[] feldPreise, int totalDiceCount, string[] alleFelder, int currentPlayer, int[] boughtGround)
    {
        System.Console.WriteLine();
        Console.WriteLine($"Möchtest du {alleFelder[totalDiceCount]} Kaufen?");
        System.Console.WriteLine("-------------------------------");


        Console.Write("[y/n]");
        string yesNo = Console.ReadLine();

        if (yesNo == "y" || yesNo == "Y")
        {
            if (bank >= feldPreise[totalDiceCount])
            {
                boughtGround[totalDiceCount] = currentPlayer;
                bank = bank - feldPreise[totalDiceCount];
                System.Console.WriteLine($"Du hast noch: {bank}");

            }
            else
            {
                Console.WriteLine("You are Broke...");
            }
        }
        else if (yesNo == "N".ToUpper())
        {
            bank = bank + 0;
        }
        return yesNo;
    }

    public static int Dicer(string[] DiceFaces)
    {
        Random random = new Random();

        int diceCount = 0;

        Console.WriteLine("Press any key to roll the dice.");
        Console.ReadLine();
        DiceAnimator(DiceFaces);

        int number = random.Next(1, 7);
        return number;

    }

    private static void DrawDice(int number, string[] DiceFaces)
    {
        int indexNum = (number - 1) * 5;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(DiceFaces[indexNum + i]);

        }
    }

    private static void DiceAnimator(string[] DiceFaces)
    {
        Random random = new Random();
        for (int i = 0; i < 7; i++)
        {
            int randomThrow = random.Next(1, 7);
            Console.Clear();
            System.Console.WriteLine("Würfeln...");
            DrawDice(randomThrow, DiceFaces);
            Thread.Sleep(500);

        }
    }

    public static void EreignisFelder(int number, int totalDiceCount, bool gefaengnissFreischein, string[] alleFelder)
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

        if (alleFelder[totalDiceCount].Contains("Ereignisfeld"))
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
            if (monopolyEreigniskarten[ereigCardNum] == monopolyEreigniskarten[13])
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

    private static void PlayerColor(int currentPlayer)
    {
        switch (currentPlayer)
        {
            case 1: Console.ForegroundColor = ConsoleColor.Magenta; break;
            case 2: Console.ForegroundColor = ConsoleColor.Blue; break;
            case 3: Console.ForegroundColor = ConsoleColor.Red; break;
            case 4: Console.ForegroundColor = ConsoleColor.Green; break;
            case 5: Console.ForegroundColor = ConsoleColor.Yellow; break;
            case 6: Console.ForegroundColor = ConsoleColor.Cyan; break;
            case 7: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
            case 8: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
            default: Console.ForegroundColor = ConsoleColor.White; break;
        }
    }
    
    private static void boardDrawer(string[] gameBoard, string[] alleFelder, int currentPlayer, int[] feldPreise, int[] boughtGround)
    {
        Console.Clear();

        foreach (string line in gameBoard)
        {
            int lastPos = 0;
            string currentLine = line;

            while (true)
            {
                int nearestPos = -1;
                int feldIndex = -1;

                // Such das NÄCHSTE Feld, das in dieser Zeile vorkommt
                for (int i = 0; i < alleFelder.Length; i++)
                {
                    int pos = currentLine.IndexOf(alleFelder[i]);
                    if (pos >= 0 && (nearestPos == -1 || pos < nearestPos))
                    {
                        nearestPos = pos;
                        feldIndex = i;
                    }
                }

                // Wenn nix mehr gefunden -> Rest ausgeben & break
                if (feldIndex == -1)
                {
                    Console.Write(currentLine);
                    break;
                }

                // Text VOR dem Feld ausgeben
                Console.Write(currentLine.Substring(0, nearestPos));

                // Farb setzen
                if (feldIndex == totalDiceCount)
                    PlayerColor(currentPlayer);
                else if (boughtGround[feldIndex] != 0)
                    PlayerColor(boughtGround[feldIndex-1]);
                else
                    Console.ForegroundColor = ConsoleColor.Gray;

                // Feldname farbig ausgeben
                Console.Write(alleFelder[feldIndex]);
                Console.ResetColor();

                // Alles nach dem Feld neu setzen
                currentLine = currentLine.Substring(nearestPos + alleFelder[feldIndex].Length);
            }

            Console.WriteLine();
        }

        Console.ResetColor();
    }
}
