using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe73
{
    public class Hardware
    {
        private string _modell;
        public string Modell
        {
            get
            {
                return _modell;
            }
            set
            {
                _modell = value;
            }
        }

        private string _serienNummer;
        public string SerienNummer
        {
            get
            {
                return _serienNummer;
            }
            set
            {
                _serienNummer = value;
            }
        }

        public Hardware(string modell, string seriennumer)
        {
            Modell = modell;
            SerienNummer = seriennumer;
        }

        public override string ToString()
        {
            return $"Modell: {Modell} SerienNummer: {SerienNummer}";
        }
    }
}