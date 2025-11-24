using System.Globalization;
using System.Runtime;
using System.Xml.Serialization;
using Appdevhb25.JulianMatt.Aufgabe72;

namespace Appdevhb25.JulianMatt.Aufgabe73
{
    public class FotoApparat : Hardware
    {
        private Objektiv _objektiv;
        private Speicherkarte _speicherkarte;

        public int AnzahlFotos = 0;


        public FotoApparat(string seriesNumber, string version) : base(seriesNumber, version)
        {

        }

        public override string ToString()
        {
            return $"{Version}, SN: {SeriesNumber} ";
        }

        public void Foto()
        {
            AnzahlFotos++;
            Speicherkarte.SaveKapacity -= 5;
        }

        public void WechsleObjektiv(Objektiv objektiv)
        {
            _objektiv = objektiv;
        }

        public void WechsleSpeicherkarte(Speicherkarte speicherkarte)
        {
            _speicherkarte = speicherkarte;
        }

        public Objektiv Objektiv
        {
            get { return _objektiv; }
        }
        public Speicherkarte Speicherkarte
        {
            get { return _speicherkarte; }
        }

        public double AnzahlVerfuegbarerFotos()
        {
            return Speicherkarte.SaveKapacity / 5;
        }
    }
}