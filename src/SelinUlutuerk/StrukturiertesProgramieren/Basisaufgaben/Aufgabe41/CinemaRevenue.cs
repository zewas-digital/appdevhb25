using System;
using Appdevhb25.SelinUlutuerk.Arrays;

namespace Appdevhb25.SelinUlutuerk.Aufgabe41
{
    class CinemaRevenue
    {
        public static void Start()
        {
            int[][] kino =
            {
                new int[3]{23, 10, 15},
                new int[4]{12, 3, 14, 11},
                new int[6]{27, 25, 22, 20, 21, 19},
                new int[2]{5, 7},
                new int[5]{14, 2, 7, 15, 10},
            };

            Console.WriteLine("Tabelle der Vorstellungsräume");
            ArrayHelper.printJaggedArray(kino);


            // Anzahl verkaufter Tickets:
            Console.WriteLine("\nAnzahl der verkauften Tickets pro Raum:");

            for (int i = 0; i < kino.Length; i++)
            {
                int anzahlTicketsproRaum = 0;
                for (int j = 0; j < kino[i].Length; j++)
                {
                    anzahlTicketsproRaum += kino[i][j];
                }
                Console.WriteLine($"Raum {i + 1}: {anzahlTicketsproRaum}");
            }


            Console.WriteLine("\nAnzahl aller verkauften Tickets:");
            int anzahlTickets = 0;
            for (int i = 0; i < kino.Length; i++)
            {
                for (int j = 0; j < kino[i].Length; j++)
                {
                    anzahlTickets += kino[i][j];
                }
            }
            Console.WriteLine($"{anzahlTickets}");


            // Durschnittliche Anzahl der Tickets pro Raum und aller Räume:
            Console.WriteLine("\nDurchschnittliche Anzahl der verkauften Tickets pro Raum:");
            for (int i = 0; i < kino.Length; i++)
            {
                int anzahlTicketsproRaum = 0;
                for (int j = 0; j < kino[i].Length; j++)
                {
                    anzahlTicketsproRaum += kino[i][j];
                }
                int durchschnittRaeume = anzahlTicketsproRaum /kino[i].Length;
                Console.WriteLine($"Raum {i + 1}: {durchschnittRaeume}");
            }


            Console.WriteLine("\nDurchschnittliche Anzahl aller verkauften Tickets:");
            int durchschnittalle = anzahlTickets/kino.Length;
            Console.WriteLine($"{durchschnittalle}");


            // Vorstellung mit den meisten verkauften Tickets pro Raum und insgesamt:
            Console.WriteLine("\nVorstellung mit den meisten verkauften Tickets pro Raum");
            for(int i = 0; i < kino.Length;i++)
            {
                int max = kino[i].Max();
                Console.WriteLine($"Raum {i+1}: {max}");
            }

            Console.WriteLine("\nVorstellung mit den meisten verkauften Tickets");
            int maxall = kino.SelectMany(r => r).Max();
            Console.WriteLine(maxall);

            // Vorstellung mit den wenigsten verkauften Tickets pro Raum und insgesamt:
            Console.WriteLine("\nVorstellung mit den wenigsten verkauften Tickets pro Raum");
            for(int i = 0; i < kino.Length;i++)
            {
                int min = kino[i].Min();
                Console.WriteLine($"Raum {i+1}: {min}");
            }


            Console.WriteLine("\nVorstellung mit den wenigesten verkauften Tickets");
            int minall = kino.SelectMany(r => r).Min();
            Console.WriteLine(minall);
        }

    }
}