using System;

namespace Appdevhb25.NoahHois.Aufgabe19
{
    public class Fuehrerschein
    {

        public static bool DarfIchMopedFahren(int alter)
        {
            if (alter >= 16)
            {
                return true;
            }
            return false;
        }

        public static bool DarfIchAutoFahren(int alter)
        {
            if (alter >= 18)
            {
                return true;
            }
            return false;
        }
        public static void AusgabeFuehrerscheine(string name, int alter)
        {
            bool moped = DarfIchMopedFahren(alter);
            bool auto = DarfIchAutoFahren(alter);
            Console.Write(name + " " + alter + ": ");
            if (moped == true)
            {
                Console.Write("Moped Ja, ");
            }
            else
            {
                Console.Write("Moped Nein, ");
            }
            if (auto == true)
            {
                Console.Write("Auto Ja, ");
            }
            else
            {
                Console.Write("Auto Nein, ");
            }
            if (auto == true && moped == true)
            {
                Console.WriteLine("für beide Fahrzeuge: Ja");
            }
            else
            {
                Console.WriteLine("für beide Fahrzeuge: Nein");
            }
        }


        public static void PruefeFuehrerscheine()
        {
            AusgabeFuehrerscheine("Michael", 16);
            AusgabeFuehrerscheine("Peter", 20);
            AusgabeFuehrerscheine("Lara", 18);
            AusgabeFuehrerscheine("Mike", 10);
            AusgabeFuehrerscheine("Seppl", 17);

        }


    }
}