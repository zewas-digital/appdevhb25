using System;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe32
{
    class Ziffernsumme
    {
        public static void Start()
        {
            string zahl;

            while (true)
            {
                Console.Write("Deine Zahl: ");
                zahl = Console.ReadLine();

                if (zahl == null)
                    break;
                    
                // Prüfen, ob alle Zeichen Ziffern sind
                bool istGueltig = true;
                foreach (char c in zahl)
                {
                    if (!char.IsDigit(c))
                    {
                        istGueltig = false;
                        break;
                    }
                }

                if (istGueltig && !string.IsNullOrWhiteSpace(zahl))
                    break;

                Console.WriteLine("Ungültige Eingabe. Bitte gib nur positive ganze Zahlen ein.");
            }


            // Ziffern addieren
            int summe = 0;
            foreach (char c in zahl)
            {
                if (int.TryParse(c.ToString(), out int ziffer))
                {
                    summe += ziffer;
                }
            }

            Console.WriteLine($"Ziffernsumme von {zahl} = {summe}");
        }
    }
}



//             int[] ziffern = new int[zahl.Length];


//             for (int i = 0; i < zahl.Length; i++)
//             {
//                 ziffern[i] = int.Parse(zahl[i].ToString());
//             }

//             int summe = 0;
//             foreach (int ziffer in ziffern)
//             {
//                 summe += ziffer;
//             }

//             Console.WriteLine($"Ziffernsumme von {zahl} = {summe}");
//         }
//     }
// }