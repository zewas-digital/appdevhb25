using System;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe32
{
    class Ziffernsumme
    {
        public static void Start()
        {
            Console.Write("Deine Zahl: ");
            string zahl = Console.ReadLine();

            int[] ziffern = new int[zahl.Length];


            for (int i = 0; i < zahl.Length; i++)
            {
                ziffern[i] = int.Parse(zahl[i].ToString());
            }

            int summe = 0;
            foreach (int ziffer in ziffern)
            {
                summe += ziffer;
            }

            Console.WriteLine($"Ziffernsumme von {zahl} = {summe}");
        }
    }
}