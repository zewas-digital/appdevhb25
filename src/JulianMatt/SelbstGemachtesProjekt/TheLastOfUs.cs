using System;

namespace Appdevhb25.JulianMatt.SelbstGemachtesProjekt
{
    internal class TheLastOfUs
    {
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
            Console.WriteLine("In der Zukunft wirst du einer jungen Frau namens Ellie begegnen, die unglaublich wichtig sein wird.");
            Console.WriteLine();
            Console.WriteLine("Drücke die ESC-Taste, um das Spiel zu starten...");

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

        }

        public static void Kapitel1()
        {
            Console.WriteLine("Kapitel 1: Der Anfang");
            Console.WriteLine("----------------------");
            Console.WriteLine("Du bist zu Hause mit deiner Tochter Sarah. Plötzlich bricht Chaos aus.");
            Console.WriteLine("Autos hupen, sirenen heulen, jemand ruft deinen Namen. Du musst schnell handeln.");
            Console.WriteLine();

            Console.WriteLine("Tommy ist dein Bruder und könnte helfen — aber du weißt nicht, wo er ist.");
            Console.WriteLine();
            Console.WriteLine("Was willst du jetzt tun?");
            Console.WriteLine("1. Sofort loslaufen und laut nach Tommy rufen, in der Hoffnung, ihn zu finden.");
            Console.WriteLine("2. Erst Waffen holen Haus sichern und Sarah finden und dann auf Tommy warten.");
            Console.WriteLine("3. Im Haus verschanzen und auf hilfe warten");
            Console.WriteLine("4. Versuchen, per Telefon Tommy zu erreichen (falls das möglich ist).");

            Console.Write("\nDeine Wahl (1–4): ");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                 if (choice1 == 1)
                {
                    Console.WriteLine("Du rennst los und rufst Tommys Namen. Die Straßen sind chaotisch und voller kommischen Kreaturen.");
                    Console.WriteLine("Plotzlich rennen alle kreaturen auf dich zu.");
                    Console.WriteLine("Sie beisen dich zu tode");
                    Console.WriteLine("Game Over");
                    Environment.Exit(0);
                }
                else if (choice1 == 2)
                {
                    Console.WriteLine("Du findest eine Pistole und Sarah kommt ganz durcheinander nach unten.");
                    Console.WriteLine("Plötzlich bricht der Nachbar Jimmy durch das Fenster du warnst ihn aber er hört nicht auf auf dich zu zu rennen du schießt und Sarah ist geschockt aber das war das Richtige");
                    Console.WriteLine("Plötzlich hört ihr eine Huppe welche von Tommy seinem Auto kommt ihr steigt ein und fähr so schnell wie möglich los ind die stadt");

                    break;
                }
                else if (choice1 == 3)
                {
                    Console.WriteLine("Du verschanzt dich mit Sarah doch niemand findet euch und die zombies schafften es irgendwie rein zukommen.");
                    Console.WriteLine("Leider sind es mittlerweile so viele das sie euch überennen");
                    Console.WriteLine("Game Over");
                    Environment.Exit(0);
                }
                else if (choice1 == 4)
                {
                    Console.WriteLine("Du versuchst Tommy anzurufen. Die Leitung ist überlastet — vielleicht bekommst du später Antwort.");
                }
                else
                {
                    Console.WriteLine("Du machst nichts und die Zombies bekommen dich");
                    Console.WriteLine("Game Over");
                    Environment.Exit(0);
                }                
            }
           
        
        }
    }
}


