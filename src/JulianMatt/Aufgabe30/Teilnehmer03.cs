using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

namespace Appdevhb25.JulianMatt.Aufgabe30
{
    public class Teilnehmer03
    {

        public static void Start30()
        {
            string[] name = TeilnehmerListe();
            TeilnehmerAnzeigen(name);
        }

        public static int TeilnehmerAnzahl()
        {
            Console.WriteLine("Wie viele Teilnehmer sind angemeldet?");

            int countOfParticipants = Convert.ToInt32(Console.ReadLine());
            return countOfParticipants;
        }

        public static string[] TeilnehmerListe()
        {

            string[] name;

            int countOfParticipants = TeilnehmerAnzahl();

            Console.WriteLine("Bitte geben sie die Namen der Teilnehmer ein:");

            name = new string[countOfParticipants];

            for (int j = 0; j < countOfParticipants; j++)
            {
                name[j] = Console.ReadLine();
            }
            return name;
        }
        public static void TeilnehmerAnzeigen(string[] name)
        {
            Console.WriteLine("Die angemeldeten Teilnehmer sind:");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + name[i]);
            }
            Console.WriteLine("Es sind " + name.Length + " Teilnehmer angemeldet.");
        }
    }


}