
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Ziffernsumme

    {
        public static void array()
        {
            Console.WriteLine("Gib eine Zahl ein: ");
            string zahl = Console.ReadLine();
            char[] zeichen = zahl.ToCharArray();

            int[] ziffern = new int[zeichen.Length];

            for (int i = 0; i < ziffern.Length; i++)
            {
                ziffern[i] = (int)char.GetNumericValue(zeichen[i]);
            }

            int summe = 0;
            for (int i = 0; i < ziffern.Length; i++)
            {
                summe += ziffern[i];
            }

            string plus = " ";
            for (int i = 0; i < ziffern.Length - 1; i++)
            {
                plus += $"{ziffern[i]} + ";
            }

            Console.WriteLine($"Die Ziffernsumme von {zahl} ist{plus}{ziffern[ziffern.Length - 1]} = {summe}");
        }
    }
}