using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Unicode;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe80
{
    class AbwesenheitIntro
    {
        public static void Start()
        {
            string pfad = @"C:\Users\aau28234\Documents\appdevneu\appdevhb25\src\SelinUlutuerk\ObjektOrientiertesProgrammieren\Bonusaufgaben\Bonusaufgabe80\Teilnehmerliste.csv";

            List<Teilnehmer> teilnehmerListe = ListenAbrufen.Laden(pfad);
            
            Console.WriteLine("Abwesenheitsliste");
            Console.WriteLine(new string('-', 40));

            foreach (var t in teilnehmerListe)
            {
                Console.WriteLine(t);
                Console.WriteLine("Abewesenheiten:");

                foreach (var a in t.Abwesenheiten)
                {
                    Console.WriteLine("\t" + a);
                }

                Console.WriteLine($"Kosten: {t.EntstandeneKosten()} €");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}