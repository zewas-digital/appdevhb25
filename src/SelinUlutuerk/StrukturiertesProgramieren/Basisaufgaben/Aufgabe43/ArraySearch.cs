using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe43
{
    class ArraySearch
    {
        public static void Start()
        {
            string satz = "this is a test sentence for the task43 with the name arraysearch";
            char[] satzinArray = satz.ToCharArray();



            Console.WriteLine(satz);

            Console.WriteLine("\nWelchen Wert möchtest du suchen?");
            string suche = Console.ReadLine();

            int indexOf = Array.IndexOf(satzinArray, suche);
            if (indexOf == -1)
            {
                Console.WriteLine($"Der Wert {suche} wurde nicht gefunden!");
            }
            else
            {
                Console.WriteLine($"Der Wert {suche} befindet sich an Index {indexOf}");
            }
        }
    }
}