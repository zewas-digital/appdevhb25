using System;
using System.Collections.Generic;
using Appdevhb25.JulianMatt.Aufgabe79;

namespace Appdevhb25.JulianMatt.Aufgabe79
{
    public class Serie
    {

        public string SeriesName;

        public string SeriesID;

        List<string> Celebrity = new List<string>();

        public Serie(string seriesName, string seriesID, List<string> celebrity)
        {
            SeriesName = seriesName;
            SeriesID = seriesID;
            Celebrity = celebrity;
        } 
    }
}