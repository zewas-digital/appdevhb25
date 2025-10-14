using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Fuehrerschein

    {
        // ohne mehrere Methoden
        public static void scheinog()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.Write("Name eingeben: ");
                string name = Console.ReadLine();

                Console.Write("Alter eingeben: ");
                int alter = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.Write($"{name} {alter}: ");

                if (alter >= 16)
                {
                    Console.Write("Moped Ja, ");
                }
                else
                {
                    Console.Write("Moped Nein, ");
                }

                if (alter >= 18)
                {
                    Console.Write("Auto Ja, für beide Fahrzeuge: Ja");
                }
                else
                {
                    Console.Write("Auto Nein, für beide Fahrzeuge: Nein");
                }
                Console.WriteLine();
            }
        }


        //mit mehreren Methoden
        public static void Schein()
        {
            Console.Write("Anzahl der Personen: ");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            string[] name = new string[anzahl];
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("Name eingeben: ");
                name[i] = Console.ReadLine();    
            }

            int[] alter = new int[anzahl];
            for (int i = 0; i < alter.Length; i++)
            {
                Console.Write("Alter eingeben: ");
                alter[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < anzahl; i++)
            {
                Console.Write($"{name[i]} {alter[i]} Moped {Moped(alter[i])}, Auto {Auto(alter[i])}, für beide Fahrzeuge: {Beide(alter[i])}");
                Console.WriteLine();
            }
        }

        public static string Moped(int alter)
        {
            if (alter >= 16)
            {
                return "Ja";

            }
            else
            {
                return "Nein";
            }
        }

        public static string Auto(int alter)
        {
            if (alter >= 18)
            {
                return "Ja";
            }
            else
            {
                return "Nein";
            }
        }

        public static string Beide(int alter)
        {
            if (alter >= 18)
            {
                return "Ja";
            }
            else
            {
                return "Nein";
            }
        }
    }
}