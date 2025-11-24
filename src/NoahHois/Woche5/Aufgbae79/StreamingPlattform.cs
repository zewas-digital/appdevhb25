namespace Appdevhb25.NoahHois.Aufgabe79
{
    public class StreamingPlattform
    {
        public Dictionary<Serie, double> Serien = new();

        public void InitPlattform()
        {
            Serie firstSeries = new Serie("One Piece", 08723);
            Serien.Add(firstSeries, 9.9);
            Serie secondSeries = new Serie("Digimon", 32840);
            Serien.Add(secondSeries, 9.2);
            Serie thirdSeries = new Serie("Bleach", 12803);
            Serien.Add(thirdSeries, 8.6);
            Serie fourthSeries = new Serie("Naruto", 02923);
            Serien.Add(fourthSeries, 4.1);
        }

        public void SetRating(string serie, double rating)
        {
            Serie oneSeries = Serien.Keys.First(series => series.Name == serie);

            if (oneSeries != null)
            {
                Serien[oneSeries] = rating;
            }
        }
        public IEnumerable<KeyValuePair<Serie, double>> OrderdSeries()
        {
            
            IEnumerable<KeyValuePair<Serie, double>> sortedList = Serien.OrderByDescending(s => s.Value);
            return sortedList;
        }
        

    }
}