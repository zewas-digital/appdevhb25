using System.Security.Cryptography;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe73
{
    public class Start
    {
        public static void FotoapparatStart()
        {
            Console.WriteLine("---\n\nAufgabe 73 - Kamera mit Hardware");
            // Instanzierung der Klassen und Demonstration der Funktionalität
            Fotoapparat fotoapparat = new Fotoapparat("FA123456", "Nikon D3500");
            Objektiv objektiv55 = new Objektiv("OB654321", "Nikon AF-P DX 18-55mm", 55);
            Objektiv objektiv200 = new Objektiv("OB987654", "Nikon AF-S DX 55-200mm", 200);
            Speicherkarte speicherkarteM = new Speicherkarte("SK112233", "SanDisk Ultra", 1024 * 32);
            Speicherkarte speicherkarteL = new Speicherkarte("SK445566", "Lexar Professional", 1024 * 64);

            // Nutzung der Methoden
            Console.WriteLine("Unser Fotoapparat: " + fotoapparat);
            fotoapparat.WechsleObjektiv(objektiv55);
            fotoapparat.WechsleSpeicherkarte(speicherkarteM);
            Console.WriteLine("\n1/\nAktuelles Objektiv: " + fotoapparat.Objektiv);
            Console.WriteLine("Aktuelle Speicherkarte: " + fotoapparat.Speicherkarte);
            fotoapparat.takePhoto();
            fotoapparat.takePhoto();
            fotoapparat.takePhoto();
            fotoapparat.takePhoto();
            Console.WriteLine("-\nAnzahl aufgenommener Fotos: " + fotoapparat.AnzahlFotos);
            Console.WriteLine("Anzahl verfügbarer Fotos auf der Speicherkarte: " + fotoapparat.AnzahlVerfuegbarerFotos());

            // Wechsel des Objektivs und der Speicherkarte
            fotoapparat.WechsleObjektiv(objektiv200);
            fotoapparat.WechsleSpeicherkarte(speicherkarteL);
            Console.WriteLine("\n2/\nGewechseltes Objektiv: " + fotoapparat.Objektiv);
            Console.WriteLine("Gewechselte Speicherkarte: " + fotoapparat.Speicherkarte);
            fotoapparat.takePhoto();
            fotoapparat.takePhoto();
            Console.WriteLine("-\nAnzahl aufgenommener Fotos: " + fotoapparat.AnzahlFotos);
            Console.WriteLine("Anzahl verfügbarer Fotos auf der Speicherkarte: " + fotoapparat.AnzahlVerfuegbarerFotos());
            Console.WriteLine("---");


            


        }
    }
}