using Org.BouncyCastle.Asn1.X509;

namespace Appdevhb25.KatjaHaemmerli.AufgabeZoo
{
    public  class Pfleger
    {
        public string PflegerName;       
        public List<Gehege> gehegeListePfleger = new List<Gehege>();
        public Pfleger(string name)
        {
            PflegerName = name;
        }
        public void PflegerGehegeHinzufuegen(Gehege gehege)
        {
            gehegeListePfleger.Add(gehege);            
        }
  
    }
}