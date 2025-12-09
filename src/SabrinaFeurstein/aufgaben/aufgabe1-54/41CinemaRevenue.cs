using System;
using System.ComponentModel.DataAnnotations;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class CinemaRevenue
    {
        public static void Vorstellungen()
        {
            Random rnd = new Random();

            int[][] rooms = new int[5][];

            for (int i = 0; i < rooms.Length; i++)
            {
                int vorstellungen = rnd.Next(2, 6);

                rooms[i] = new int[vorstellungen];
                for (int j = 0; j < vorstellungen; j++)
                {
                    rooms[i][j] = rnd.Next(0, 100);
                }
            }

            int[] verkauftRaum = new int[rooms.Length];
            int verkauftRaumTemp;
            int verkauftInsgesamt = 0;
            int anzahlVeranstaltungen = 0;

            int[] maxRaum = new int[rooms.Length];
            int[] maxZahl = new int[rooms.Length];
            int maxRaumTemp;
            int maxZahlTemp;
            int maxInsgesamt = 0;
            int raumMax = 0;
            int vorstellungMax = 0;

            int[] minRaum = new int[rooms.Length];
            int[] minZahl = new int[rooms.Length];
            int minRaumTemp;
            int minZahlTemp;
            int minInsgesamt;
            int raumMin = 0;
            int vorstellungMin = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                verkauftRaumTemp = 0;
                maxRaumTemp = 0;
                maxZahlTemp = 0;

                for (int j = 0; j < rooms[i].Length; j++)
                {
                    verkauftRaumTemp += rooms[i][j];
                    if (maxZahlTemp < rooms[i][j])
                    {
                        maxRaumTemp = j;
                        maxZahlTemp = rooms[i][j];
                    }
                }

                verkauftRaum[i] = verkauftRaumTemp;
                verkauftInsgesamt += verkauftRaumTemp;
                anzahlVeranstaltungen += rooms[i].Length;

                maxRaum[i] = maxRaumTemp;
                maxZahl[i] = maxZahlTemp;

                if (maxInsgesamt < maxZahl[i])
                {
                    maxInsgesamt = maxZahl[i];
                    raumMax = i;
                    vorstellungMax = maxRaumTemp;
                }
            }

            minInsgesamt = maxInsgesamt;

            for (int i = 0; i < rooms.Length; i++)
            {
                minRaumTemp = 0;
                minZahlTemp = maxInsgesamt;

                for (int j = 0; j < rooms[i].Length; j++)
                {
                    if (minZahlTemp > rooms[i][j])
                    {
                        minRaumTemp = j;
                        minZahlTemp = rooms[i][j];
                    }
                }

                minRaum[i] = minRaumTemp;
                minZahl[i] = minZahlTemp;

                if (minInsgesamt > minZahl[i])
                {
                    minInsgesamt = minZahl[i];
                    raumMin = i;
                    vorstellungMin = minRaumTemp;
                }
            }

            for (int i = 0; i < rooms.Length; i++)
            {
                Console.WriteLine($"Raum {i + 1}");
                for (int j = 0; j < rooms[i].Length; j++)
                {
                    Console.WriteLine($"Vorstellung {j + 1}: {rooms[i][j]} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Tickets verkauft pro Raum: {verkauftRaum[i]}");
                Console.WriteLine($"Durchschnitt der verkauften Tickets pro Raum: {verkauftRaum[i] / rooms[i].Length}");
                Console.WriteLine($"Vorstellung mit den meisten verkauften Tickets pro Raum: Vorstellung {maxRaum[i] + 1} ({maxZahl[i]} Tickets)");
                Console.WriteLine($"Vorstellung mit den wenigsten verkauften Tickets pro Raum: Vorstellung {minRaum[i] + 1} ({minZahl[i]} Tickets)");
                Console.WriteLine();
            }
            Console.WriteLine($"Tickets verkauft insgesamt: {verkauftInsgesamt}");
            Console.WriteLine($"Durchschnitt der verkauften Tickets insgesamt: {verkauftInsgesamt / anzahlVeranstaltungen}");
            Console.WriteLine($"Vorstellung mit den meisten verkauften Tickets insgesamt: Raum {raumMax + 1}, Vorstellung {vorstellungMax + 1} ({maxInsgesamt} Tickets)");
            Console.WriteLine($"Vorstellung mit den wenigsten verkauften Tickets insgesamt: Raum {raumMin + 1}, Vorstellung {vorstellungMin + 1} ({minInsgesamt} Tickets)");
        }
    }
}