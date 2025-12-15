public class Objektiv
{
        public Objektiv(string seriennummer, string modell, int brennweite)
    {
        
    }       
    
        private double _brennweite;
        public double Brennweite
        {
            get
            {
                return _brennweite;
            }
            set
            {
                _brennweite = value;
            }
        }
        
       
}