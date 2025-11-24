using System.Runtime.InteropServices.ObjectiveC;
using System.Security.Cryptography;
using Appdevhb25.KerimAlkis.Bonusaufgabe06;
using Appdevhb25.KerimAlkis.Bonusaufgabe72;

namespace Appdevhb25.KerimAlkis.Vertiefungsaufgabe73
{
    public class HardwareDerKamera
    {
        public static void Start()
        {
            Console.WriteLine("---\n\nAufgabe 73 - Kamera mit Hardware");
            // Instanzierung der Klassen und Demonstration der Funktionalität
            Fotoapparat2 fotoapparat = new Fotoapparat2("FA123456", "Nikon D3500");
            Objektiv2 objektiv55 = new Objektiv2("OB654321", "Nikon AF-P DX 18-55mm", 55);
            Objektiv2 objektiv200 = new Objektiv2("OB987654", "Nikon AF-S DX 55-200mm", 200);
            Speicherkarte2 speicherkarteM = new Speicherkarte2("SK112233", "SanDisk Ultra", 1024 * 32);
            Speicherkarte2 speicherkarteL = new Speicherkarte2("SK445566", "Lexar Professional", 1024 * 64);

            // Nutzung der Methoden
            Console.WriteLine("Unser Fotoapparat: " + fotoapparat);
            fotoapparat.WechsleObjektiv(objektiv55);
            fotoapparat.WechsleSpeicherkarte(speicherkarteM);
            Console.WriteLine("\n1/\nAktuelles Objektiv: " + fotoapparat._objektiv);
            Console.WriteLine("Aktuelle Speicherkarte: " + fotoapparat._speicherkarte);
            fotoapparat.Foto();
            fotoapparat.Foto();
            fotoapparat.Foto();
            fotoapparat.Foto();
            Console.WriteLine("-\nAnzahl aufgenommener Fotos: " + fotoapparat.AnzahlFotos);
            Console.WriteLine("Anzahl verfügbarer Fotos auf der Speicherkarte: " + fotoapparat.AnzahlVerfuegbarerFotos());

            // Wechsel des Objektivs und der Speicherkarte
            fotoapparat.WechsleObjektiv(objektiv200);
            fotoapparat.WechsleSpeicherkarte(speicherkarteL);
            Console.WriteLine("\n2/\nGewechseltes Objektiv: " + fotoapparat._objektiv);
            Console.WriteLine("Gewechselte Speicherkarte: " + fotoapparat._speicherkarte);
            fotoapparat.Foto();
            fotoapparat.Foto();
            Console.WriteLine("-\nAnzahl aufgenommener Fotos: " + fotoapparat.AnzahlFotos);
            Console.WriteLine("Anzahl verfügbarer Fotos auf der Speicherkarte: " + fotoapparat.AnzahlVerfuegbarerFotos());
            Console.WriteLine("---");
        }
    }
    public abstract class Hardware
    {
        private string _typ;
        public string Typ{ get{ return _typ; } set{ _typ = value; } }
        public string Model;
        public string Seriennummer;

        public Hardware(string model, string seriennumer)
        {
            Model = model;
            Seriennummer = seriennumer;
        }
        public override string ToString()
        {
            return $"\nTyp: {Typ}\nModel: {Model}\nSeriennummer: {Seriennummer}";
        }
    }
    public class Fotoapparat2 : Hardware
    {
        public int AnzahlFotos;
        public Objektiv2 _objektiv;
        public Speicherkarte2 _speicherkarte;

        public Fotoapparat2(string model, string seriennummer) : base(model, seriennummer)
        {
            Typ = "Fotoapparat";
        }
        public void Foto()
        {
            if (_speicherkarte == null)
            {
                System.Console.WriteLine("Es ist noch keine Speicherkarte eingelegt");
                return;
            }
            else if (_speicherkarte.Speichergroesse <= 4)
            {
                System.Console.WriteLine("Die Speicherkarte ist voll");
                return;
            }
            _speicherkarte.Speichergroesse -= 5;
            AnzahlFotos++;
        }
        public void WechsleObjektiv(Objektiv2 neuesObjektiv)
        {
            _objektiv = neuesObjektiv;
            System.Console.WriteLine("Das Objektiv wurde gewechselt");

        }
        public void WechsleSpeicherkarte(Speicherkarte2 neueSpeicherkarte)
        {
            _speicherkarte = neueSpeicherkarte;
            System.Console.WriteLine("Die Speicherkarte wurde gewechselt");
        }
        public int  AnzahlVerfuegbarerFotos()
        {
            return (int)_speicherkarte.Speichergroesse / 5;
        }

    }
    public class Objektiv2 : Hardware
    {
        public int Brennweite;
        public Objektiv2(string model, string seriennummer, int brennweite) : base(model, seriennummer)
        {
            Typ = "Objektiv";
            Brennweite = brennweite;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nBrennweite: {Brennweite}"; 
        }
    }
    public class Speicherkarte2 : Hardware
    {
        private double _speichergroesse;
        public double Speichergroesse;
        public Speicherkarte2(string model, string seriennummer, double speichergroesse) : base(model, seriennummer)
        {
            Typ = "Speicherkarte";
            Speichergroesse = speichergroesse;
            _speichergroesse = speichergroesse;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nSpeicher: {_speichergroesse}/{Speichergroesse}"; 
        }
    }
}