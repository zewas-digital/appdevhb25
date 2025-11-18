using System.Globalization;
using System;
using System.Linq;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe79
{
    public class StreamingPlattform
    {
        private Dictionary<Series, double> SeriesAndRatings = new Dictionary<Series, double>();

        
        public void makeSeries()
        {
            Series name = new Series();
            name._name = "Breaking Bad";
            Series name1 = new Series();
            name1._name = "Bojack Horseman";
            Series name2 = new Series();
            name2._name = "Stranger Things";
            Series name3 = new Series();
            name3._name = "Brooklyn 99";
            Series name4 = new Series();
            name4._name = "How i met your Mother";

            SeriesAndRatings.Add(name, 8);
            SeriesAndRatings.Add(name1, 10);
            SeriesAndRatings.Add(name2, 7);
            SeriesAndRatings.Add(name3, 9);
            SeriesAndRatings.Add(name4, 7);
            DictPrinter(SeriesAndRatings);
        }
        public void UserRateSeries(Series seriesName, double userRating)
        {
            Series? key = SeriesAndRatings.Keys.FirstOrDefault(s => s._name.Contains(seriesName._name, StringComparison.OrdinalIgnoreCase));
            if (key != null)
            {
                SeriesAndRatings[key] = userRating;
            }
            else
            {
                System.Console.WriteLine("Series not Found");
            }
            DictPrinter(SeriesAndRatings);
        }

        public void DictPrinter(Dictionary<Series, double> userDict)
        {
            foreach (var item in userDict)
            {
                Console.WriteLine($"Series: {item.Key._name}, Rating: {item.Value}");
            }
        }


    }
    
}