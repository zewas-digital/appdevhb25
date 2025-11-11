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

        private int _usedSaveKapacity;

        public int UsedSaveKapacity
        {
            get { return _usedSaveKapacity; }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Der Speicher kann nicht weniger als 0 Aufgenutzt sein");
                }
                else
                {
                    _usedSaveKapacity = value;
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