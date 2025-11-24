namespace Appdevhb25.LiaLouiseNatter.Aufgabe72
{
    public class Fotoapparat
    {
        private int FotoAnz;
        public string Modell;
        public Objektiv objektiv;
        public Speicherkarte speicherKarte;

        private float _megapixel;
        public float Megapixel
        {
            get
            {
                return _megapixel;
            }
            set
            {
                if (value < 0.01 || value > 1000)
                {
                    System.Console.WriteLine("Minimale Megapixel: 0,1MP und Maximale Megapixel: 1000MP");
                }
                else
                {
                    _megapixel = value;
                }
            }
        }

        public void takePhoto()
        {
            System.Console.WriteLine($"Die Kamera: {Modell} mit der Megapixelzahl: {Megapixel} hat ein Foto gemacht.");
            FotoAnz++;
            speicherKarte.SpeicherkartenPLatz -= Megapixel * 0.3;
            speicherKarte.SpeicherplatzPrinter();
            objektiv.ObjektivPrinter();
            System.Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}


























































































