using System.Globalization;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Aufgabe73
{
    public abstract class Hardware
    {
        public string SeriesNumber;
        public string Version;

        public Hardware( string seriesNumber, string version)
        {
            SeriesNumber = seriesNumber;
            Version = version;
        }
    }
}