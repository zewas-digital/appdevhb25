using System;

namespace Appdevhb25.JulianMatt.SelbstGemachtesProjekt
{
    internal class TheLastOfUs
    {
        static Random random = new Random();
        static int playerHealth = 100;
        static int zombieHealth = 0;

        public static void StartTheLastOfUs()
        {
            Einführung();
            Kapitel();
        }

        public static void Einführung()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            string logo = @"
==================================
          THE LAST OF US
==================================
";
            Console.WriteLine(logo);
            Console.ResetColor();

            Console.WriteLine("Willkommen zu 'The Last of Us'!");
            Console.WriteLine("Du bist Joel. Deine Tochter heißt Sarah.");
            Console.WriteLine("Die Welt um euch bricht zusammen — Explosionen, Schreie und Chaos überall.");
            Console.WriteLine("Drücke ESC, um das Spiel zu starten...");

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    break;
                }
            }
        }

        public static void Kapitel()
        {
            Kapitel1();
            Kapitel2();
        }

        public static void Kapitel1()
        {
            Console.WriteLine("Kapitel 1: Der Anfang");
            Console.WriteLine("----------------------");
            Console.WriteLine("Du bist zu Hause mit deiner Tochter Sarah. Plötzlich bricht Chaos aus.");
            Console.WriteLine("Autos hupen, Sirenen heulen, jemand ruft deinen Namen. Du musst schnell handeln.");
            Console.WriteLine();

            Console.WriteLine("Was willst du tun?");
            Console.WriteLine("1. Laut nach Tommy rufen.");
            Console.WriteLine("2. Waffen holen und Sarah sichern.");
            Console.WriteLine("3. Im Haus verschanzen.");
            Console.WriteLine("4. Versuchen, Tommy anzurufen.");

            Console.Write("\nDeine Wahl (1–4): ");
            while (true)
            {
                int choice1 = Convert.ToInt32(Console.ReadLine());
                if (choice1 == 1)
                {
                    GameOver("Du rennst los, rufst nach Tommy. Zombies hören dich zuerst — du wirst überrannt!");
                }
                else if (choice1 == 2)
                {
                    Console.WriteLine("Du findest eine Pistole und warnst Sarah. Der Nachbar Jimmy bricht durchs Fenster!");
                    Console.WriteLine("Du schießt. Sarah ist geschockt, aber ihr überlebt.");
                    Console.WriteLine("Draußen hupt Tommy. Ihr steigt ein und fahrt Richtung Stadt...");
                    break;
                }
                else if (choice1 == 3)
                {
                    GameOver("Ihr verschanzt euch, aber irgendwann brechen sie durch. Zu viele...");
                }
                else if (choice1 == 4)
                {
                    Console.WriteLine("Leitung tot. Kein Signal. Du greifst nach der Pistole und suchst Sarah.");
                }
                else
                {
                    GameOver("Du zögerst zu lange. Zombies brechen ein. Ende.");
                }
            }
        }

        public static void Kapitel2()
        {
            Console.WriteLine("Kapitel 2: Der Ausbruch");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Ihr fahrt mit Tommy durch brennende Straßen. Menschen rennen panisch umher.");
            Console.WriteLine("Plötzlich kracht ein Auto von der Seite in euch hinein!");
            Console.WriteLine("Ihr seid benommen, aber am Leben. Sarah ist verletzt.");
            Console.WriteLine("Tommy hilft euch raus. Du hörst ein grunzen...");
            Console.WriteLine();
            Console.WriteLine("Ein infizierter nähert sich!");

            ZombieEncounter("Infizierter", "Feuer", 40, 20);
            Console.WriteLine("Tommy ruft: 'Los Joel! Wir müssen durch das Krankenhaus!'");

            Console.WriteLine("\n1. Durch die Gasse schleichen.");
            Console.WriteLine("2. Mit der Shotgun durchrennen.");
            Console.Write("\nDeine Wahl: ");
            int choice2 = Convert.ToInt32(Console.ReadLine());

            if (choice2 == 1)
            {
                Console.WriteLine("Ihr schleicht erfolgreich durch die Gasse. Aber ihr hört in der Ferne weitere Schreie...");
            }
            else
            {
                Console.WriteLine("Du rennst los und schießt auf alles, was sich bewegt. Munition wird knapp, aber ihr schafft es raus!");
                ZombieEncounter("Clicker", "Feuer", 60, 30);
            }

            Console.WriteLine("\nIhr erreicht schließlich den Stadtrand. Die Nacht ist ruhig — zu ruhig...");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nFortsetzung folgt...");
            Console.ResetColor();
        }

        // === ZOMBIE ENCOUNTER SYSTEM ===
        public static void ZombieEncounter(string zombieName, string weakness, int zombieDamage, int baseDamage)
        {
            zombieHealth = 80 + random.Next(20, 60);
            Console.WriteLine($"\n⚠️  Ein {zombieName} erscheint!");
            Console.WriteLine($"Deine Gesundheit: {playerHealth} | {zombieName}-Gesundheit: {zombieHealth}");
            Console.WriteLine();

            while (zombieHealth > 0 && playerHealth > 0)
            {
                Console.WriteLine("Wähle deine Waffe:");
                Console.WriteLine("1. Pistole (30 Schaden)");
                Console.WriteLine("2. Shotgun (50 Schaden, aber 40% Chance auf Kopftreffer für 100 Schaden)");
                Console.WriteLine("3. Flammenwerfer (40 Schaden, doppelt gegen Feuer-Schwäche)");
                Console.Write("\nDeine Wahl: ");

                int weapon = Convert.ToInt32(Console.ReadLine());
                int damage = 0;

                switch (weapon)
                {
                    case 1:
                        damage = baseDamage;
                        break;
                    case 2:
                        if (random.Next(1, 101) <= 40)
                        {
                            Console.WriteLine("🔥 Kopftreffer!");
                            damage = 100;
                        }
                        else
                        {
                            Console.WriteLine("Du triffst, aber nicht den Kopf.");
                            damage = 50;
                        }
                        break;
                    case 3:
                        damage = 40;
                        if (weakness == "Feuer")
                        {
                            Console.WriteLine("🔥 Schwachstelle getroffen! Doppelschaden!");
                            damage *= 2;
                        }
                        break;
                    default:
                        Console.WriteLine("Du zögerst – der Zombie greift an!");
                        break;
                }

                zombieHealth -= damage;
                if (zombieHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nDu hast den {zombieName} besiegt!");
                    Console.ResetColor();
                    break;
                }

                // Zombie greift zurück
                int zombieAttack = random.Next(15, zombieDamage + 1);
                playerHealth -= zombieAttack;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{zombieName} trifft dich für {zombieAttack} Schaden!");
                Console.ResetColor();

                Console.WriteLine($"Deine HP: {playerHealth} | {zombieName} HP: {zombieHealth}");
                Console.WriteLine();

                if (playerHealth <= 0)
                {
                    GameOver("Der Zombie hat dich erwischt. Sarah schreit, bevor alles schwarz wird...");
                }
            }
        }

        // === GAME OVER FUNKTION ===
        public static void GameOver(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n" + message);
            Console.WriteLine("Game Over");
            Console.ResetColor();
            Environment.Exit(0);
        }
    }
}
