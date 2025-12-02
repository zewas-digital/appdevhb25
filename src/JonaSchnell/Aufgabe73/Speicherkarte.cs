using System;

namespace Appdevhb25.JonaSchnell.Aufgabe73
{
    public class Speicherkarte
    {
        public string Seriennummer { get; }
        public string Hersteller { get; }
        public int GroesseKB { get; }

        public int KapazitaetFotos { get; }
        public int VerfuegbareFotos { get; private set; }

        public Speicherkarte(string seriennummer, string hersteller, int groesseKB)
        {
            Seriennummer = seriennummer;
            Hersteller = hersteller;
            GroesseKB = groesseKB;
            KapazitaetFotos = Math.Max(0, GroesseKB / 1024);
            VerfuegbareFotos = KapazitaetFotos;
        }

        public Speicherkarte(string seriennummer, string hersteller, int kapazitaetFotos, bool isPhotos)
        {
            Seriennummer = seriennummer;
            Hersteller = hersteller;
            GroesseKB = kapazitaetFotos * 1024;
            KapazitaetFotos = Math.Max(0, kapazitaetFotos);
            VerfuegbareFotos = KapazitaetFotos;
        }

        public void NutzeFoto()
        {
            if (VerfuegbareFotos > 0)
                VerfuegbareFotos--;
        }

        public void Format()
        {
            VerfuegbareFotos = KapazitaetFotos;
        }

        public override string ToString()
        {
            return $"{Hersteller} {KapazitaetFotos} Fotos (frei: {VerfuegbareFotos})";
        }
    }
}