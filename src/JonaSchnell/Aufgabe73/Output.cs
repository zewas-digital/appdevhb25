namespace Appdevhb25.JonaSchnell.Aufgabe73
{
    public static class Output
    {
        public static void StartCamera()
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
            Console.WriteLine("\n1/\nAktuelles Objektiv: " + fotoapparat.ObjektivName);
            Console.WriteLine("Aktuelle Speicherkarte: " + speicherkarteM + " - Fotos frei: " + fotoapparat.AnzahlVerfuegbarerFotos());
            fotoapparat.Foto();
            fotoapparat.Foto();
            fotoapparat.Foto();
            fotoapparat.Foto();
            Console.WriteLine("-\nAnzahl aufgenommener Fotos: " + fotoapparat.AnzahlFotos);
            Console.WriteLine("Anzahl verfügbarer Fotos auf der Speicherkarte: " + fotoapparat.AnzahlVerfuegbarerFotos());

            // Wechsel des Objektivs und der Speicherkarte
            fotoapparat.WechsleObjektiv(objektiv200);
            fotoapparat.WechsleSpeicherkarte(speicherkarteL);
            Console.WriteLine("\n2/\nGewechseltes Objektiv: " + fotoapparat.ObjektivName);
            Console.WriteLine("Gewechselte Speicherkarte: " + speicherkarteL + " - Fotos frei: " + fotoapparat.AnzahlVerfuegbarerFotos());
            fotoapparat.Foto();
            fotoapparat.Foto();
            Console.WriteLine("-\nAnzahl aufgenommener Fotos: " + fotoapparat.AnzahlFotos);
            Console.WriteLine("Anzahl verfügbarer Fotos auf der Speicherkarte: " + fotoapparat.AnzahlVerfuegbarerFotos());
            Console.WriteLine("---");
        }
    }
}