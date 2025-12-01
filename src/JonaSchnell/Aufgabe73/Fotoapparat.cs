using System;

namespace Appdevhb25.JonaSchnell.Aufgabe73
{
    public class Fotoapparat
    {
        public string Seriennummer { get; }
        public string Modell { get; }
        public string ObjektivName { get; private set; }
        public int VerfuegbareFotos { get; private set; }
        public int AnzahlFotos { get; private set; }
        public Fotoapparat(string seriennummer, string modell)
        {
            Seriennummer = seriennummer;
            Modell = modell;
            ObjektivName = "Ich hab keine Idee";
            VerfuegbareFotos = 0;
            AnzahlFotos = 0;
        }

        public override string ToString()
        {
            return $"{Modell} ({Seriennummer})";
        }
        public void WechsleObjektiv(string name)
        {
            ObjektivName = string.IsNullOrWhiteSpace(name) ? "kein Objektiv" : name;
        }

        public void WechsleObjektiv(Objektiv objektiv)
        {
            if (objektiv == null) { ObjektivName = "kein Objektiv"; return; }
            ObjektivName = objektiv.Name;
        }

        public void LegeSpeicherkarteEin(int kapazitaetFotos)
        {
            VerfuegbareFotos = Math.Max(0, kapazitaetFotos);
        }
        public void WechsleSpeicherkarte(Speicherkarte karte)
        {
            if (karte == null) { VerfuegbareFotos = 0; return; }
            VerfuegbareFotos = karte.VerfuegbareFotos;
        }

        public void Foto()
        {
            if (VerfuegbareFotos <= 0)
            {
                Console.WriteLine("Keine Fotos möglich, keine oder volle Speicherkarte.");
                return;
            }
            AnzahlFotos++;
            VerfuegbareFotos--;
            Console.WriteLine($"Foto aufgenommen mit {Modell} {ObjektivName} (insgesamt: {AnzahlFotos})");
        }

        public int AnzahlVerfuegbarerFotos() => VerfuegbareFotos;
    }
}