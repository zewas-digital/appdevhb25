
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class RandomNumberArray

    {
        public static void array()
        {
            int anzahl = 5;
            double[] teilnehmer = new double[anzahl];

            Console.WriteLine($"Anzahl der Teilnehmer: {teilnehmer.Length}");

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(0, 100);
                teilnehmer[i] = random;
            }

            for (int i = 0; i < teilnehmer.Length; i++)
            {
                Console.WriteLine(teilnehmer[i]);
            }

            double max = 0;
            for (int i = 0; i < teilnehmer.Length; i++)
            {
                if (teilnehmer[i] > max)
                {
                    max = teilnehmer[i];
                }
            }

            double min = max;
            for (int i = 0; i < teilnehmer.Length; i++)
            {
                if (teilnehmer[i] < min)
                {
                    min = teilnehmer[i];
                }
            }

            double summe = 0;
            for (int i = 0; i < teilnehmer.Length; i++)
            {
                summe += teilnehmer[i];
            }

            double average = summe / teilnehmer.Length;


            Console.WriteLine();
            Console.WriteLine($"größter Wert: {max}");
            Console.WriteLine($"kleinster Wert: {min}");
            Console.WriteLine($"Durchschnitt aller Werte: {average}");
            Console.WriteLine($"Summe aller Werte: {summe}");

            Console.WriteLine();
            Console.WriteLine("Kontrolle der Werte");
            Console.WriteLine($"größter Wert: {teilnehmer.Max()}");
            Console.WriteLine($"kleinster Wert: {teilnehmer.Min()}");
            Console.WriteLine($"Durchschnitt aller Werte: {teilnehmer.Average()}");
            Console.WriteLine($"Summe aller Werte: {teilnehmer.Sum()}");
        }
    }
}