
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Fuehrerschein

    {
        // int alter = Convert.ToInt32(Console.ReadLine());
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


        //In Bearbeitung
        public static int schein()
        {
            int alter = 15;
            return alter;
        }

        public static void moped(int alter)
        {
            moped(schein());
            if (alter >= 16)
            {
                Console.Write("Moped Ja, ");
            }
            else
            {
                Console.Write("Moped Nein, ");
            }
        }

        public static void auto(int alter)
        {
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
}






// class FuehrerscheinPruefung
// {
//     static bool DarfMopedFahren(int alter)
//     {
//         return alter >= 15;
//     }

//     static bool DarfAutoFahren(int alter)
//     {
//         return alter >= 18;
//     }

//     // static void Main1()
//     // {
//     //     var personen = new Dictionary<string, int>
//     //     {
//     //         { "Anna", 14 },
//     //         { "Ben", 16 },
//     //         { "Clara", 18 },
//     //         { "David", 20 },
//     //         { "Eva", 17 }
//     //     };

//         foreach (var person in personen)
//         {
//             string name = person.Key;
//             int alter = person.Value;

//             bool moped = DarfMopedFahren(alter);
//             bool auto = DarfAutoFahren(alter);

//             string berechtigung;
//             if (moped && auto)
//                 berechtigung = "Moped und Auto";
//             else if (moped)
//                 berechtigung = "nur Moped";
//             else if (auto)
//                 berechtigung = "nur Auto";
//             else
//                 berechtigung = "keines von beiden";

//             Console.WriteLine($"{name} ({alter} Jahre): {berechtigung}");
//         }
//     }
// }



// class FuehrerscheinPruefung2
// {
//     static bool DarfMopedFahren(int alter)
//     {
//         return alter >= 15;
//     }

//     static bool DarfAutoFahren(int alter)
//     {
//         return alter >= 18;
//     }

//     static void Main2()
//     {
//         Console.WriteLine("Wie viele Personen möchten Sie prüfen?");
//         int anzahl = int.Parse(Console.ReadLine());

//         for (int i = 1; i <= anzahl; i++)
//         {
//             Console.WriteLine($"\nPerson {i}:");
//             Console.Write("Name: ");
//             string name = Console.ReadLine();

//             Console.Write("Alter: ");
//             int alter = int.Parse(Console.ReadLine());

//             bool moped = DarfMopedFahren(alter);
//             bool auto = DarfAutoFahren(alter);

//             string berechtigung;
//             if (moped && auto)
//                 berechtigung = "Moped und Auto";
//             else if (moped)
//                 berechtigung = "nur Moped";
//             else if (auto)
//                 berechtigung = "nur Auto";
//             else
//                 berechtigung = "keines von beiden";

//             Console.WriteLine($"{name} ({alter} Jahre): {berechtigung}");
//         }
//     }
// }

// class FuehrerscheinPruefung3
// {
//     static bool DarfMopedFahren(int alter)
//     {
//         return alter >= 15;
//     }

//     static bool DarfAutoFahren(int alter)
//     {
//         return alter >= 18;
//     }

//     static void Main3()
//     {
//         string antwort;

//         do
//         {
//             Console.WriteLine("Wie viele Personen möchten Sie prüfen?");
//             int anzahl = int.Parse(Console.ReadLine());

//             for (int i = 1; i <= anzahl; i++)
//             {
//                 Console.WriteLine($"\nPerson {i}:");
//                 Console.Write("Name: ");
//                 string name = Console.ReadLine();

//                 Console.Write("Alter: ");
//                 int alter = int.Parse(Console.ReadLine());

//                 bool moped = DarfMopedFahren(alter);
//                 bool auto = DarfAutoFahren(alter);

//                 string berechtigung;
//                 if (moped && auto)
//                     berechtigung = "Moped und Auto";
//                 else if (moped)
//                     berechtigung = "nur Moped";
//                 else if (auto)
//                     berechtigung = "nur Auto";
//                 else
//                     berechtigung = "keines von beiden";

//                 Console.WriteLine($"{name} ({alter} Jahre): {berechtigung}");
//             }

//             Console.WriteLine("\nMöchten Sie weitere Personen prüfen? (ja/nein)");
//             antwort = Console.ReadLine().ToLower();

//         } while (antwort == "ja");

//         Console.WriteLine("Programm beendet.");
//     }
// }