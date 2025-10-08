
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Teilnehmer

    {
        public static void kurs()
        {
            string[] teilnehmer =
            [
                "Jona",
                "Kerim",
                "Julian",
                "Katja",
                "Sabrina",
                "Selin",
                "Sheila",
                "Lia",
                "Laura",
                "Sasha",
            ];
            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine(teilnehmer[i]);
            }
            Console.WriteLine($"Anzahl der Teilnehmer: {teilnehmer.Length}");
        }

    }
}