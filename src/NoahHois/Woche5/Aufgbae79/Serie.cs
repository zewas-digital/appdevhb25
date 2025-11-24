namespace Appdevhb25.NoahHois.Aufgabe79
{
    public class Serie
    {
        public string Name;
        public int SeriesID;
        public List<Schauspieler> Cast = new List<Schauspieler>();

        public Serie(string name, int seriesID)
        {
            Name = name;
            SeriesID = seriesID;
        }
    }
}