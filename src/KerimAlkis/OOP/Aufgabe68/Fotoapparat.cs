namespace Appdevhb25.KerimAlkis.Aufgabe68
{
    public class Fotoapparat
    {
        public static void Start()
        {
            //FotoapparatModel apparat1 = new FotoapparatModel();
        }
    }

    public class FotoapparatModel
    {
        private int _brennweite;
        public int Brennweite{get{ return _brennweite; } set{ _brennweite = value; }}
        
        public string Model;
        public string Hersteller;
        public double Megapixel;

        public FotoapparatModel(int brennweite, string model, string hersteller, double megapixel)
        {
            Brennweite = brennweite;
            Model = model;
            Hersteller = hersteller;
            Megapixel = megapixel;
        }

        public void takePhoto()
        {
            System.Console.WriteLine("Foto");
        }

    }
}