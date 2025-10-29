using System;
using System.Reflection.Metadata.Ecma335;

namespace Appdevhb25.SelinUlutuerk.Aufgabe26
{
    class Fuehrerschein
    {
        public static void Start()
        {
            Console.WriteLine("Dein Name: ");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine("Dein Alter: ");
            int alter = Convert.ToInt32(Console.ReadLine());

            var beides = Auto(alter) == "Ja" ? "für beide Fahrzeuge Ja" : "für beide Fahrzeuge Nein";

            Console.Write($"{name} {alter}: Moped {Moped(alter)}, Auto {Auto(alter)}, {beides}");
        }

        public static string Moped(int alter)
        {
            if (alter < 15)
            {
                return "Nein";
            }
            else
            {
                return "Ja";
            }
        }
        public static string Auto(int alter)
        {
            if (alter < 18 || alter < 15)
            {
                return "Nein";
            }
            else
            {
                return "Ja";
            }
        }
        
        /* Wäre andere Option, wenn man oben anstatt {beides} einfach diese Methode einfügt - geht auch
        public static string Beide(int alter)
        {
            if (Moped(alter) == "Ja" && Auto(alter) == "Ja")
            {
                return "für beide Fahrzeuge: Ja";
            }
            else
            {
                return "für beide Fahrzeuge: Nein";
            }
        }
        */
    }
}