using System;
using System.Collections.Generic;

namespace Appdevhb25.SelinUlutuerk.Aufgabe77
{
    class DictionaryIntro
    {
        public static void Start()
        {
            var serienVerwaltung = new Serien();

            serienVerwaltung.serienHinzufuegen(
                ("TVD", 8.5),
                ("Peaky Blinders", 9.0),
                ("Selling Sunset", 6.0),
                ("Brief an die Zukunft", 5.3),
                ("Outer Banks", 2.2)
            );

            serienVerwaltung.AlleSerienSortiert();
            serienVerwaltung.SerienUeberAcht(8.0);
            serienVerwaltung.BesteSerie();
            serienVerwaltung.SucheSerie();
        }
    }
}

