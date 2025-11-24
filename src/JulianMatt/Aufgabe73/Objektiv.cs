using System.Globalization;
using System.Runtime.InteropServices.ObjectiveC;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Aufgabe73
{
    public class Objektiv : Hardware
    {
        private int _brennweite;
        public int Brennweite
        {
            get { return _brennweite; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Die Brennweite kann nicht 0 sein");
                }
                else
                {
                    _brennweite = value;
                }
            }
        }

        public Objektiv(string seriesNumber, string version, int brennweite) : base(seriesNumber, version)
        {
            Brennweite = brennweite;
        }

        public override string ToString()
        {
            return $" {Version}, SN: {SeriesNumber}, Brennweite: {Brennweite}";
        }
    }
}
