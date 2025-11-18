using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using Appdevhb25.JulianMatt.Aufgabe65;
using Appdevhb25.JulianMatt.Aufgabe77;
using Appdevhb25.JulianMatt.Aufgabe79;

namespace Appdevhb25.JulianMatt.Aufgabe79
{
    public class StreamingPlatform
    {
        public List<Serie> serienListe = new List<Serie>();
        Dictionary<string, double> Rating = new Dictionary<string, double>();

        public void FillRatingUp()
        {
            Rating.Add("TLOU", 9);
            Rating.Add("TBATE", 5);
            Rating.Add("AOT", 7);
            Rating.Add("FMAB", 10);
            Rating.Add("Stranger things", 4);
            Rating.Add("SAO", 8);

            serienListe.Add(new Serie("The Last of Us", "TLOU", new List<string> { "Pedro Pascal", "Bella Ramsey", "Nico Parker" }));
            serienListe.Add(new Serie("TBATE", "TBATE", new List<string> { "Arthur", "Varay Longuard" }));
            serienListe.Add(new Serie("Attack on Titan", "AOT", new List<string> { "Eren Yeager", "Mikasa Ackerman", "Armin", "Levi" }));
            serienListe.Add(new Serie("Full Metal Alchemist", "FMAB", new List<string> { "Edward Elric", "Alphonse Elric" }));
            serienListe.Add(new Serie("Stranger things", "Stranger things", new List<string> { "Elfi", "Mike", "Will", "Dustin", "Lucas" }));
            serienListe.Add(new Serie("Sword Art Online", "SAO", new List<string> { "Kirito", "Asuna", "Sinon" }));
        }

        public void Print()
        {
            for (int i = 0; i < serienListe.Count; i++)
            {
                Serie s = serienListe[i];
                double currentRating = Rating[s.SeriesID];
                Console.WriteLine((i + 1) + ". Serie: " + s.SeriesName + " Rating: " + currentRating + "/10");
            }
        }

        public void RatingInput(int index)
        {
            Serie ausgewaehlt = serienListe[index];

            Console.WriteLine("Geben Sie Ihre Bewertung für " + ausgewaehlt.SeriesName + " ein (0-10):");
            double rating = Convert.ToDouble(Console.ReadLine());

            if (rating > 10)
            {
                System.Console.WriteLine("Das ist eine invalide Bewertung bewerten sie bitte fair sie betrüger.");
            }
            else
            {
                RatingCalculator(ausgewaehlt.SeriesID, rating);
            }

        }

        public void RatingCalculator(string id, double newRating)
        {
            double oldRating = Rating[id];
            double final = (oldRating + newRating) / 2;

            Rating[id] = final;

            Console.WriteLine("Neue Bewertung: " + final);
        }

        public void TopThreeSeries()
        {
            List<Serie> sorted = new List<Serie>(serienListe);

            sorted.Sort((a, b) => Rating[b.SeriesID].CompareTo(Rating[a.SeriesID]));

            Console.WriteLine("Top 3 Serien:");
            for (int i = 0; i < 3; i++)
            {
                Serie serie = sorted[i];
                Console.WriteLine((i + 1) + ". " + serie.SeriesName + " " + Rating[serie.SeriesID] + "/10");
            }
        }

    }
}