using System;
using System.ComponentModel;

namespace Appdevhb25.NoahHois.Aufgabe33
{
    public class ArraySearch
    {
        public static void Start()
        {
            string[] mainArray = { "Datum", "Tee", "Auto", "Kamin", "Grundstuecksverkehrsgenehmigungszustaendigkeitsuebertragungsverordnung", "Erlebnis", "Sieben", "Kochlöffel", "Zebra", "Maus", "Haus", "Parallel", "Qualle", "Berg", "Vogel" };
            Console.WriteLine("Gib bitte einen Wert von 1 - 15 ein: ");
            string? s = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < mainArray.Length; i++)
            {
                if (s == mainArray[i])
                {
                    Console.WriteLine(i);
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Der Wert konnte nicht gufunden werden.");
            }

            Console.WriteLine("Gib bitte eine Silbe ein: ");
            string? input = Console.ReadLine();

            for (int i = 0; i < mainArray.Length; i++)
            {
                if (mainArray[i].ToLower().Contains(input.ToLower()))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}