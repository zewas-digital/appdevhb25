namespace Appdevhb25.JulianMatt.Aufgabe73
{
    public class Speicherkarte : Hardware
    {
        private int _saveKapacity;

        public int SaveKapacity
        {
            get { return _saveKapacity; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Der speicher kann nicht 0 sein");
                }
                else
                {
                    _saveKapacity = value;
                }
            }
        }

        public Speicherkarte(string seriesNumber, string version, int saveKapacity) : base(seriesNumber, version)
        {
            SaveKapacity = saveKapacity;
        }

        public override string ToString()
        {
            return $" {Version}, SN: {SeriesNumber}, Speichergröße: {SaveKapacity} MB";
        }

    }
}