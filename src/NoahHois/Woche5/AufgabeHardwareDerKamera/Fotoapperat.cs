using System.Runtime.CompilerServices;

namespace Appdevhb25.NoahHois.Aufgabe73
{
    public class Fotoapperat : Hardware
    {
        public int AnzahlFotos;
        public Objektiv Objektiv;
        public Speicherkarte Speicherkarte;
        public int VerbrauchterSpeicher;

        public Fotoapperat(string seriennummer, string modell) : base(modell, seriennummer)
        {

        }
        public void Foto()
        {
            AnzahlFotos++;
            Speicherkarte.Speichergroeße -= 5;
        }
        public void WelchesObjektiv(Objektiv objektiv)
        {
            Objektiv = objektiv;
        }
        public void WechsleSpeicherkarte(Speicherkarte speicherkarte)
        {
            Speicherkarte = speicherkarte;
        }
        public int AnzahlVerfuegbarenFotos()
        {
            return (Speicherkarte.Speichergroeße - VerbrauchterSpeicher) / 5;
        }
        public override string ToString()
        {
            return $"{Modell}, SN: {Seriennummer}";
        }
    }
}