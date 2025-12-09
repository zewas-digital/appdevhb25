using System;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe103
{
    public class DBRead
    {
        public static void Start()
        {
            Bibliotheksverwaltung bib = new Bibliotheksverwaltung();

            // Autoren lesen
            bib.LeseAutoren();

            // Bücher lesen
            bib.LeseBuecher();


            foreach (var buch in bib.Buecher)
            {
                Console.WriteLine(buch);
            }
            System.Console.WriteLine();

            foreach (var autor in bib.Autoren)
            {
                Console.WriteLine(autor);
            }
            System.Console.WriteLine();

        }
    }
}