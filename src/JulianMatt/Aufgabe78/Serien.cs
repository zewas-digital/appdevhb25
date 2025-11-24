using System;
using System.Collections.Generic;
using Appdevhb25.JulianMatt.Aufgabe78;

namespace Appdevhb25.JulianMatt.Aufgabe78
{
    public class Serien
    {
        Dictionary<string, double> Rating = new Dictionary<string, double>();
        public void FillRatingUp()
        {
            Rating.Add("TLOU", 9);
            Rating.Add("TBATE", 5);
            Rating.Add("AOT", 7);
            Rating.Add("FMAB", 10);
            Rating.Add("Stranger things", 4);
            Rating.Add("SAO", 8);
        }

        public List<KeyValuePair<string, double>> SortByName()
        {
            return Rating.OrderBy(KVP => KVP.Key).ToList();
        }

    }
}