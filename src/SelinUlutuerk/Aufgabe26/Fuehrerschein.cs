using System;
using System.Reflection.Metadata.Ecma335;

namespace Appdevhb25.SelinUlutuerk.Aufgabe26
{
    class Fuehrerschein
    {
        public static void Start()
        {
            Console.WriteLine("Dein Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Dein Alter: ");
            int alter = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"{name} {alter}: Moped {Moped(alter)}, Auto {Auto(alter)}");
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
        
    }
}