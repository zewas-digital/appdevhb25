using System;

namespace Appdevhb25.JulianMatt.SelbstGemachtesProjekt
{
    internal class TheLastOfUs
    {
        static Random random = new Random();
        static int playerHealth = 100;
        static int zombieHealth = 0;

        static int medKits = 3;
        static int pistolAmmo = 15;
        static int shotgunAmmo = 5;
        static int molotovs = 2;


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
            Kapitel3();
            Kapitel4();
            Kapitel5();
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
        public static void Kapitel3()
        {
            Console.Clear();
            Console.WriteLine("Kapitel 3: 20 Jahre später");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Zwanzig Jahre sind vergangen. Die Welt gehört nun den Infizierten und FEDRA kontrolliert die Quarantänezonen mit Gewalt.");
            Console.WriteLine("Joel ist älter, härter. Tess ist seine Partnerin im Schmuggelgeschäft.");
            Console.WriteLine();
            Console.WriteLine("Tess: 'Joel, Marlene von den Fireflies will uns sehen. Dringend.'");
            Console.WriteLine("1. 'Ich trau der nicht, aber gehen wir.'");
            Console.WriteLine("2. 'Wenn’s was bringt, bin ich dabei.'");
            Console.Write("\nDeine Wahl: ");

            Console.ReadLine();
            Console.WriteLine("\nIhr trefft Marlene in einem verlassenen Theater. Sie ist verletzt.");
            Console.WriteLine("Marlene: 'Ich brauche euch. Ihr müsst etwas... jemanden... aus der Stadt schmuggeln.'");
            Console.WriteLine("Joel: 'Jemanden?'");
            Console.WriteLine("Marlene: 'Ein Mädchen. Ellie.'");

            Console.WriteLine("\nTess: 'Wir nehmen den Job. Bezahlt wird danach.'");
            Console.WriteLine("Marlene: 'Bringt sie zu den Fireflies außerhalb der Stadt.'");
            Console.ReadKey();

            Console.WriteLine("\nSpäter, in der Nacht:");
            Console.WriteLine("Ihr schleicht euch mit Ellie aus der Quarantänezone. Scheinwerfer streifen die Straße...");
            Console.WriteLine("Soldaten schreien: 'Halt! Stehenbleiben! Das Gebiet ist gesperrt!'");

            Console.WriteLine("\nTess: 'Verdammt, FEDRA!' – Sie ziehen ihre Waffen.");
            FedraKampf(true); // Erster realistischer FEDRA-Encounter

            Console.WriteLine("\nEllie: 'Sind das... Soldaten?'");
            Console.WriteLine("Joel: 'Nicht mehr.'");
            Console.WriteLine("Tess: 'Schnell, durch die alten Abwasserkanäle!'");

            Kapitel4();
        }

        public static void Kapitel4()
        {
            Console.Clear();
            Console.WriteLine("Kapitel 4: Unter der Stadt");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Ihr steigt in die alten Kanäle unter Boston. Dunkel, nass, Sporen in der Luft.");
            Console.WriteLine("Ellie hustet. Joel zieht seine Gasmaske auf.");
            Console.WriteLine("Tess: 'Sei still, Kind. Da vorne bewegt sich was...'");
            Console.WriteLine();
            Console.WriteLine("Ein Clicker kreischt aus der Dunkelheit!");
            ZombieEncounter("Clicker", "Feuer", 50, 30);

            Console.WriteLine("\nNach dem Kampf:");
            Console.WriteLine("Tess: 'Verdammt... ich wurde gebissen.'");
            Console.WriteLine("Joel: 'Was?!'");
            Console.WriteLine("Tess: 'Ich bleibe hier. Du bringst sie zu Bill. Er schuldet uns was.'");
            Console.WriteLine("Joel zögert, aber sie zwingt ihn zu gehen... Dann stürmt FEDRA herein.");
            Console.WriteLine("Tess kämpft bis zum Schluss.");
            Console.ReadKey();

            Console.WriteLine("\nJoel: 'Komm, Ellie. Wir müssen weiter.'");
            Console.WriteLine("Ellie: 'Wohin?'");
            Console.WriteLine("Joel: 'Zu Bill. Er hat Waffen, Vorräte... und hoffentlich Antworten.'");

            Kapitel5();
        }

        public static void Kapitel5()
        {
            Console.Clear();
            Console.WriteLine("Kapitel 5: Auf dem Weg zu Bill");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Joel und Ellie wandern durch verlassene Vororte. Häuser von der Natur überwuchert.");
            Console.WriteLine("Ellie: 'Also... dieser Bill. Was ist das für einer?'");
            Console.WriteLine("Joel: 'Ein Überlebenskünstler. Paranoid. Voller Fallen.'");
            Console.WriteLine();

            Console.WriteLine("Am Boden liegt ein alter Rucksack.");
            Console.WriteLine("Du findest 5 Pistolen-Munition und 1 MedKit.");
            pistolAmmo += 5;
            medKits++;
            Console.WriteLine($"🔫 Pistolen-Munition: {pistolAmmo} |  Medkits: {medKits}");
            Console.ReadKey();

            Console.WriteLine("\nPlötzlich hörst du Schritte – Banditen!");
            Console.WriteLine("Sie wollen eure Vorräte.");
            Console.WriteLine();
            Console.WriteLine("1. Schleichen und vorbeigehen.");
            Console.WriteLine("2. Kampf suchen.");
            Console.Write("\nDeine Wahl: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\nIhr schleicht leise durch die Ruinen... aber einer entdeckt euch!");
                FedraKampf(false);
            }
            else
            {
                Console.WriteLine("Du ziehst deine Waffe!");
                FedraKampf(false);
            }

            Console.WriteLine("\nNach dem Kampf: Ellie zittert, aber sie hält sich tapfer.");
            Console.WriteLine("Joel: 'Gut gemacht, Kleines.'");

            Console.WriteLine("\nIhr erreicht einen alten Vorort. Überall improvisierte Fallen.");
            Console.WriteLine("Joel: 'Das ist Bills Gebiet. Halt dich hinter mir.'");
            Console.ReadKey();

            Console.WriteLine("Plötzlich – eine Falle löst aus! Du hängst kopfüber in der Luft!");
            Console.WriteLine("Ellie: 'Joel!' – Runner kommen angerannt!");
            ZombieEncounter("Runner", "Feuer", 30, 25);

            Console.WriteLine("\nBill taucht auf, schießt mit der Schrotflinte und rettet euch.");
            Console.WriteLine("Bill: 'Scheiße, Joel! Du bringst mir Kinder mit?!'");
            Console.WriteLine("Joel: 'Freut mich auch, dich zu sehen, Bill.'");
            Console.WriteLine("Ellie: 'Netter Empfang...'");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Fortsetzung folgt...");
            Console.ResetColor();
        }

        // ======= KAMPFSYSTEM FÜR FEDRA UND INVENTAR =======
        public static void FedraKampf(bool firstEncounter)
        {
            int fedraHealth = 100 + random.Next(20, 40);

            if (firstEncounter)
            {
                Console.WriteLine("\n FEDRA-Soldaten blockieren den Ausgang! Sie haben euch entdeckt!");
            }
            else
            {
                Console.WriteLine("\n  Banditen greifen an!");
            }

            Console.WriteLine($"Deine HP: {playerHealth} | Gegner HP: {fedraHealth}");
            Console.WriteLine($" Pistole: {pistolAmmo} Schuss |  Medkits: {medKits} |  Molotovs: {molotovs}");
            Console.WriteLine();

            while (fedraHealth > 0 && playerHealth > 0)
            {
                Console.WriteLine("Wähle deine Aktion:");
                Console.WriteLine("1. Mit Pistole schießen (30 Schaden)");
                Console.WriteLine("2. Molotow werfen (50 Schaden)");
                Console.WriteLine("3. MedKit benutzen (+40 HP)");
                Console.WriteLine("4. Nahkampf (20 Schaden, 30% Krit-Chance)");
                Console.Write("\nDeine Wahl: ");

                int action = Convert.ToInt32(Console.ReadLine());
                int damage = 0;

                switch (action)
                {
                    case 1:
                        if (pistolAmmo > 0)
                        {
                            pistolAmmo--;
                            Console.WriteLine("Du feuerst deine Pistole ab!");
                            damage = 30;
                        }
                        else
                        {
                            Console.WriteLine(" Klick! Keine Munition!");
                        }
                        break;

                    case 2:
                        if (molotovs > 0)
                        {
                            molotovs--;
                            Console.WriteLine(" Du wirfst einen Molotow!");
                            damage = 50;
                        }
                        else
                        {
                            Console.WriteLine("Keine Molotovs mehr!");
                        }
                        break;

                    case 3:
                        if (medKits > 0)
                        {
                            medKits--;
                            playerHealth += 40;
                            if (playerHealth > 100) playerHealth = 100;
                            Console.WriteLine($" Du benutzt ein MedKit. HP wieder auf {playerHealth}.");
                        }
                        else
                        {
                            Console.WriteLine("Keine Medkits mehr!");
                        }
                        break;

                    case 4:
                        if (random.Next(1, 101) <= 30)
                        {
                            Console.WriteLine(" Kritischer Nahkampftreffer!");
                            damage = 60;
                        }
                        else
                        {
                            Console.WriteLine("Du triffst, aber nicht stark genug.");
                            damage = 20;
                        }
                        break;

                    default:
                        Console.WriteLine("Du zögerst – der Gegner schießt zuerst!");
                        break;
                }

                fedraHealth -= damage;
                if (fedraHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nDu hast den Gegner besiegt!");
                    Console.ResetColor();
                    Console.WriteLine("Du findest 3 Pistolen-Munition und 1 Molotow auf dem Boden.");
                    pistolAmmo += 3;
                    molotovs++;
                    break;
                }

                int attack = random.Next(15, 30);
                playerHealth -= attack;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Der Gegner trifft dich für {attack} Schaden!");
                Console.ResetColor();

                Console.WriteLine($"Deine HP: {playerHealth} | Gegner HP: {fedraHealth}");
                Console.WriteLine($"Munition: {pistolAmmo} | Molotovs: {molotovs} | Medkits: {medKits}\n");

                if (playerHealth <= 0)
                {
                    GameOver("Du wirst getroffen und gehst zu Boden... Ellie ruft deinen Namen.");
                }
            }
        }

        public static void ZombieEncounter(string zombieName, string weakness, int zombieDamage, int baseDamage)
        {
            zombieHealth = 80 + random.Next(20, 60);
            Console.WriteLine($"\n  Ein {zombieName} erscheint!");
            Console.WriteLine($"Deine Gesundheit: {playerHealth} | {zombieName}-Gesundheit: {zombieHealth}");
            Console.WriteLine($" Pistolen-Munition: {pistolAmmo} |  Molotovs: {molotovs} |  Medkits: {medKits}");
            Console.WriteLine();

            while (zombieHealth > 0 && playerHealth > 0)
            {
                Console.WriteLine("Wähle deine Aktion:");
                Console.WriteLine("1. Pistole (30 Schaden)");
                Console.WriteLine("2. Shotgun (50 Schaden, 40% Chance auf Kopftreffer)");
                Console.WriteLine("3. Molotow (40 Schaden, doppelt bei Feuer-Schwäche)");
                Console.WriteLine("4. Nahkampf (15 Schaden, 20% Krit-Treffer = 40 Schaden)");
                Console.WriteLine("5. MedKit benutzen (+40 HP)");
                Console.Write("\nDeine Wahl: ");

                int weapon = Convert.ToInt32(Console.ReadLine());
                int damage = 0;

                switch (weapon)
                {
                    case 1:
                        if (pistolAmmo > 0)
                        {
                            pistolAmmo--;
                            damage = baseDamage;
                            Console.WriteLine(" Du schießt mit der Pistole!");
                        }
                        else
                        {
                            Console.WriteLine(" Keine Munition mehr!");
                        }
                        break;

                    case 2:
                        if (shotgunAmmo > 0)
                        {
                            shotgunAmmo--;
                            if (random.Next(1, 101) <= 40)
                            {
                                Console.WriteLine(" Kopftreffer!");
                                damage = 100;
                            }
                            else
                            {
                                Console.WriteLine("Du triffst, aber nicht den Kopf.");
                                damage = 50;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Keine Shotgun-Munition mehr!");
                        }
                        break;

                    case 3:
                        if (molotovs > 0)
                        {
                            molotovs--;
                            damage = 40;
                            if (weakness == "Feuer")
                            {
                                Console.WriteLine(" Schwachstelle getroffen! Doppelschaden!");
                                damage *= 2;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Keine Molotovs mehr!");
                        }
                        break;

                    case 4:
                        if (random.Next(1, 101) <= 20)
                        {
                            Console.WriteLine(" Kritischer Nahkampftreffer!");
                            damage = 40;
                        }
                        else
                        {
                            Console.WriteLine("Du triffst im Nahkampf.");
                            damage = 15;
                        }
                        break;

                    case 5:
                        if (medKits > 0)
                        {
                            medKits--;
                            playerHealth += 40;
                            if (playerHealth > 100) playerHealth = 100;
                            Console.WriteLine($" Du benutzt ein MedKit. HP: {playerHealth}");
                        }
                        else
                        {
                            Console.WriteLine("Keine MedKits mehr!");
                        }
                        break;

                    default:
                        Console.WriteLine("Du zögerst – der Zombie greift an!");
                        break;
                }

                // Schaden anwenden
                if (damage > 0)
                {
                    zombieHealth -= damage;
                    if (zombieHealth <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\n Du hast den {zombieName} besiegt!");
                        Console.ResetColor();
                        Console.WriteLine("Du findest etwas Beute...");

                        // Loot-System
                        int lootRoll = random.Next(1, 101);
                        if (lootRoll <= 40)
                        {
                            pistolAmmo += 3;
                            Console.WriteLine(" Du findest 3 Pistolen-Munition!");
                        }
                        else if (lootRoll <= 70)
                        {
                            medKits++;
                            Console.WriteLine(" Du findest ein MedKit!");
                        }
                        else if (lootRoll <= 90)
                        {
                            molotovs++;
                            Console.WriteLine(" Du findest einen Molotow!");
                        }
                        else
                        {
                            Console.WriteLine("Nichts Nützliches gefunden...");
                        }

                        break;
                    }
                }

                // Zombie greift zurück
                int zombieAttack = random.Next(10, zombieDamage + 1);
                playerHealth -= zombieAttack;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{zombieName} trifft dich für {zombieAttack} Schaden!");
                Console.ResetColor();

                Console.WriteLine($"Deine HP: {playerHealth} | {zombieName} HP: {zombieHealth}");
                Console.WriteLine($"Munition: {pistolAmmo} | MedKits: {medKits} | Molotovs: {molotovs}\n");

                if (playerHealth <= 0)
                {
                    GameOver("Der Infizierte reißt dich zu Boden... Alles wird schwarz.");
                }
            }
        }

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
