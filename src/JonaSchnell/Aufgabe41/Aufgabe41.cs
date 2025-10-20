using System;
using System.Data;
using System.Drawing;

namespace Appdevhb25.JonaSchnell.Aufgabe41
{
    public class Aufgabe41
    {
        public static void Start41()
        {
            var rnd = new Random();
            int reservated = 5;
            int[][] jagged = new int[reservated][];
            int films = 0;
            int allFilms = 0;
            int tickets = 0;
            int allTickets = 0;
            int money = 0;
            int globalMax = 0;
            int globalMin = 601;
            int mostPeopleRoom = 0;
            int leastPeopleRoom = 0;

            //Filme für die Vorstellungen
            string[] filmIdeas = { "The Exorcist", "Halloween", "A Nightmare on Elm Street", "Psycho", "The Shining", "It", "The Texas Chain Saw Massacre", "The Blair Witch Project", "Candyman", "Hereditary", "Get Out", "The Ring", "The Conjuring", "The Witch", "Midsommar", "Insidious", "The Babadook", "Paranormal Activity", "Scream", "The Others", "Sinister", "The Cabin in the Woods", "Dawn of the Dead", "Carrie" };

            for (int i = 0; i < reservated; i++)
            {
                //Vorstellungen
                films = rnd.Next(2, 6);
                jagged[i] = new int[films];
                allFilms = allFilms + films;
                for (int j = 0; j < films; j++)
                {
                    //Besetzte Plätze
                    jagged[i][j] = rnd.Next(0, 600);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Es sind " + reservated + " Säle verwendet worden, und es waren " + allFilms + " Vorstellungen.");
            Console.WriteLine("");
            for (int i = 0; i < jagged.Length; i++)
            {
                //Säle Counter + ausgabe
                Console.WriteLine("Saal " + (i + 1));
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    //Randomizer für String für Filme
                    Random random = new Random();
                    string filmName = filmIdeas[random.Next(filmIdeas.Length)];


                    Console.Write(jagged[i][j] + " (" + jagged[i][j] * 10 + "€ )" + " [" + filmName + "] ");

                    money = money + jagged[i][j] * 10 + jagged[i][j] * 6;

                    Console.WriteLine();
                    tickets = tickets + jagged[i][j];

                    //Minimum und Maximum 
                    if (globalMax < jagged[i][j])
                    {
                        globalMax = jagged[i][j];
                        mostPeopleRoom = i + 1;
                    }

                    if (globalMin > jagged[i][j])
                    {
                        globalMin = jagged[i][j];
                        leastPeopleRoom = i + 1;
                    }

                }
                allTickets = allTickets + tickets;
                Console.WriteLine("Für den Raum " + (i + 1) + " wurden " + tickets + " Tickets verkaut.");
                Console.WriteLine("Das sind im Durchschnitt " + (tickets / jagged[i].Length) + " pro Vorstellung.");
                Console.WriteLine();
                tickets = 0;
            }

            Console.WriteLine("In allen Sälen wurden Insgesamt " + allTickets + " verkauft. Das sind durchschnittlich " + (allTickets / 6) + ". Damit wurden " + money + "€ gemacht.");
            Console.WriteLine("Die meisten Leute waren " + globalMax + " und sie waren im Saal " + mostPeopleRoom + ".");
            Console.WriteLine("Die wenigsten Leute waren " + globalMin + " und sie waren im Saal " + leastPeopleRoom + ".");
        }
    }
}