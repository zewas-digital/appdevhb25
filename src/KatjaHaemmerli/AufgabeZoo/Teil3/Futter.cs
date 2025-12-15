using Org.BouncyCastle.Asn1.X509;

namespace Appdevhb25.KatjaHaemmerli.AufgabeZoo
{
    public  class Futter
    {
        public string FutterName;        
        public string Einheit;
        public double Einheitspreis;
        public string Waehrung;
        public Futter(string futtername, string einheit, double einheitspreis, string waehrung)
        {
            FutterName = futtername;            
            Einheit = einheit;
            Einheitspreis = einheitspreis;
            Waehrung = waehrung;
        }
  
    }
}