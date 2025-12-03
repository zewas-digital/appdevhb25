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

            // Bücher lesen
            bib.LeseBuecher();

            // Autoren lesen
            bib.LeseAutoren();


            foreach(var buch in bib.Buecher)
            {
                Console.WriteLine(buch);
            }
            System.Console.WriteLine();

            foreach(var autor in bib.Autoren)
            {
                Console.WriteLine(autor);
            }
            System.Console.WriteLine();

        }
    }
}