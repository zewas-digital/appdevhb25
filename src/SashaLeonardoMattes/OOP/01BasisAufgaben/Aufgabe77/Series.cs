using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe77
{

    public class Series
    {
        public Dictionary<string, double> Seriesdict = new Dictionary<string, double>();

        public Dictionary<string, double> getSeries()
        {
            Dictionary<string, double>? orderedSeries = Seriesdict?.OrderBy(s => s.Key).ToDictionary();
            if (orderedSeries != null)
            {
                return orderedSeries;
            }
            return new Dictionary<string, double>();
        }

        public Dictionary<string, double> getGoodSeries()
        {
            return Seriesdict.Where(s => s.Value > 8.0).ToDictionary();
        }

        public Dictionary<string, double> getBestSeries()
        {
            double max = Seriesdict.Max(s => s.Value);
            return Seriesdict.Where(s => s.Value == max).ToDictionary();
        } 
    
        public void SearchSeries(string name)
        {
            Dictionary<string, double>? result = Seriesdict.Where(s => s.Key == name).ToDictionary();
            if (result.Count == 0)
            {
                System.Console.WriteLine("Serie nicht gefunden");
            }
            else
            {
                System.Console.WriteLine("Serie gefunden Rating: " + result[name]);
            }
           
        }
    
    }
}
