using System;
using System.Security.Cryptography.X509Certificates;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe91
{
    public class Kasse
    {
        public double Tagesumsatz;

        List<Warenkorb> abgerechneteWarenkoerbe = new List<Warenkorb>();
        public Kasse()
        {
            
        }

        public void WarenkorbAbrechnen(Warenkorb warenkorb)
        {
            abgerechneteWarenkoerbe.Add(warenkorb);
        }
        public double GesamtpreisBerechnen() //Rückgabetyp string weil return einen String zurück gibt
        {
            double summe = 0;
            foreach(Warenkorb warenkorb in abgerechneteWarenkoerbe)
            {
                summe += warenkorb.getGesamtPreis();
            }
            return summe;
        }
        public string AusgabeTagesumsatz()
        {
            return $"Der Tagesumsatz von Kasse beträgt: {Tagesumsatz}";
        }


    }
}