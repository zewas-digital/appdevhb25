using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe66
{
    public class Intro
    {
        public static void Start()
        {
            Personen[] personens = new Personen[1];

            personens[0] = new Personen();
            personens[0].Groesse = 1.65;
            personens[0].Geburtsdatum = new DateTime(2004,08,02);
            personens[0].Name = "Selin";
            personens[0].Gewicht = 55;

            for (int i = 0; i < personens.Length; i++)
            {
                personens[i].PrintPersonen();
                personens[i].GetBirthday();
                System.Console.WriteLine();
            }
        }
    }
}