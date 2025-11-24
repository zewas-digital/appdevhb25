using System.Runtime.InteropServices.ObjectiveC;
using System.Security.Cryptography;

namespace Appdevhb25.KerimAlkis.Bonusaufgabe72
{
    public class Fotoapparat
    {
        public static void Start()
        {
            FotoapparatModel fotoapp1 = new FotoapparatModel("Alpha7", "Sony", 33);
            Objektiv obj1 = new Objektiv(35, 500);
            Speicherkarte speicher1 = new Speicherkarte(256_000, "UHS-I", 40);

            fotoapp1.objektiv = obj1;
            fotoapp1.speicherkarte = speicher1;

            do
            {
                fotoapp1.takePhoto();
            } while (speicher1.Speicher >= 0);

            fotoapp1.DrueckeDaten();
        }
    }

    public class FotoapparatModel
    {
        public string Model;
        public string Hersteller;
        public double Megapixel;
        public int AnzahlBilder;

        public Objektiv objektiv;
        public Speicherkarte speicherkarte;

        public FotoapparatModel(string model, string hersteller, double megapixel)
        {
            Model = model;
            Hersteller = hersteller;
            Megapixel = megapixel;
        }

        public void takePhoto()
        {
            System.Console.WriteLine("Foto wurde geschossen");
            speicherkarte.Speicher -= (0.3*Megapixel);
            AnzahlBilder++;
        }

        public void DrueckeDaten()
        {
            System.Console.WriteLine("Geschossene Bilder: "+ AnzahlBilder);
        }

    }
    public class Objektiv
    {
        public int Brennweite;
        public double Preis;

        public Objektiv(int brennweite, double preis)
        {
            Brennweite = brennweite;
            Preis = preis;
        }

    }
    public class Speicherkarte
    {
        public double Speicher;
        public string Typ;
        public double Preis;

        public Speicherkarte(double speicher, string typ, double preis)
        {
            Speicher = speicher;
            Typ = typ;
            Preis = preis;
        }
    }
}