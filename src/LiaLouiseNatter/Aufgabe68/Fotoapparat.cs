namespace Appdevhb25.LiaLouiseNatter.Aufgabe68
{
    public class Fotoapparat
    {
        private float _brennweite;
        public float Brennweite
        {
            get
            {
                return _brennweite;
            }
            set
            {
                if (value < 2 || value > 3000)
                {
                    System.Console.WriteLine("Die minimale Brennweite beträgt 2mm und die Maximale beträgt 3000mm");
                }
                else
                {
                    _brennweite = value;
                }
            }
        }

        public string Modell;

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
            System.Console.WriteLine($"Die Kamera: {Modell} mit der Brennweite: {Brennweite} und der Megapixelzahl: {Megapixel} hat ein Foto gemacht.");
            System.Console.WriteLine();
        }
    }
}


























































































