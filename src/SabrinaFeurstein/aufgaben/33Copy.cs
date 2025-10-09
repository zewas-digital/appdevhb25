
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Copy

    {
        // public static void Array()
        // {
        //     string[] teilnehmer =
        //      [
        //          "Jona",
        //         "Kerim",
        //         "Julian",
        //         "Katja",
        //         "Sabrina",
        //         "Selin",
        //         "Sheila",
        //         "Lia",
        //         "Laura",
        //         "Sasha",
        //     ];
        //     string[] copy = new string[teilnehmer.Length];

        //     for (int i = 0; i < copy.Length; i++)
        //     {
        //         copy[i] = teilnehmer[i];
        //     }

        //     for (int i = 0; i < teilnehmer.Length; i++)
        //     {
        //         Console.WriteLine(teilnehmer[i]);
        //     }

        //     for (int i = 0; i < copy.Length; i++)
        //     {
        //         Console.WriteLine(copy[i]);

        //     }
        // }


        public static int[] Kopie(int[] original)
        {
            int[] copy = new int[original.Length];

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = original[i];
            }
            return copy;
        }

        public static void Array()
        {
            Random rnd = new Random();
            int[] original = new int[5];

            for (int i = 0; i < original.Length; i++)
            {
                original[i] = rnd.Next(0, 100);
            }
            int[] kopie = Kopie(original);

            original[0] = -1;

            foreach (int elem in original)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
            foreach (int elem in kopie)
            {
                Console.WriteLine(elem);
            }
        }
    }
}