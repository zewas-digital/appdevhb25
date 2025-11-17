namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe72
{
    public class Objektiv
    {
        private int _brennweite;

        public int Brennweite 
        {
            get
            {
                return _brennweite;
            }
            set
            {
                if (value >= 7 && value <= 2000)
                    _brennweite = value;
                else
                    Console.WriteLine("Brennweite kann nicht kürzer als 7mm oder länger als 2000mm sein!");
            }
        }

        public Objektiv(int brennweite)
        {
            Brennweite = brennweite;
        }
    }
}