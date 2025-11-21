namespace Appdevhb25.LiaLouiseNatter.Aufgabe91
{
    public class WarenkorbItem
    {
        private double _preis;
        private int _menge;

        public double Preis
        {
            get 
            { 
                return _preis; 
            }
            set 
            { 
                _preis = value; 
            }
        }

        public int Menge
        {
            get 
            { 
                return _menge; 
            }
            set 
            { 
                _menge = value; 
            }
        }

 
        public double GetGesamtpreis()
        {
            return _preis * _menge;
        }
    }
}