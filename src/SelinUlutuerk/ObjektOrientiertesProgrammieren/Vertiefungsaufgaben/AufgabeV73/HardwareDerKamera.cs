namespace Appdevhb25.SelinUlutuerk.AufgabeV73
{
    public class HardwareDerKamera
    {
        public static void Start()
        {
            //Angaben aus der Aufgabe
            Console.WriteLine("---\n\nAufgabe 73 - Kamera mit Hardware");
            // Instanzierung der Klassen und Demonstration der Funktionalität

            Objektiv objektiv55 = new Objektiv("OB654321", "Nikon AF-P DX 18-55mm", 55);
            Objektiv objektiv200 = new Objektiv("OB987654", "Nikon AF-S DX 55-200mm", 200);
            Speicherkarte speicherkarteM = new Speicherkarte("SK112233", "SanDisk Ultra", 1024 * 32);
            Speicherkarte speicherkarteL = new Speicherkarte("SK445566", "Lexar Professional", 1024 * 64);

            Fotoapparat fotoapparat = new Fotoapparat("FA123456", "Nikon D3500", objektiv55, speicherkarteM);

            Console.WriteLine("Unser Fotoapparat: " + fotoapparat);
            fotoapparat.WechselObjektiv(objektiv55);
            fotoapparat.WechselSpeichekarte(speicherkarteM);
            Console.WriteLine("\n1/\nAktuelles Objektiv: " + fotoapparat.Objektiv);
            Console.WriteLine("Aktuelle Speicherkarte: " + fotoapparat.Karte);
            Console.WriteLine("-\nAnzahl aufgenommener Fotos: " + fotoapparat.AnzhalFotos);
            Console.WriteLine("Anzahl verfügbarer Fotos auf der Speicherkarte: " + fotoapparat.AnzahlVerfuegbarenFotos());


            // Wechsel des Objektivs und der Speicherkarte
            fotoapparat.WechselObjektiv(objektiv200);
            fotoapparat.WechselSpeichekarte(speicherkarteL);
            Console.WriteLine("\n2/\nGewechseltes Objektiv: " + fotoapparat.Objektiv);
            Console.WriteLine("Gewechselte Speicherkarte: " + fotoapparat.Karte);
            fotoapparat.Foto();
            Console.WriteLine("-\nAnzahl aufgenommener Fotos: " + fotoapparat.AnzhalFotos);
            Console.WriteLine("Anzahl verfügbarer Fotos auf der Speicherkarte: " + fotoapparat.AnzahlVerfuegbarenFotos());
            Console.WriteLine("---");




            // eigener Test
            // Fotoapparat[] kameras = new Fotoapparat[1];

            // Objektiv sonyObjektiv = new Objektiv("Sony E-Mount", "L-100001", 28.0);
            // Speicherkarte sonyKarte = new Speicherkarte("SanDisk", "S-00001", 1045);

            // kameras[0] = new Fotoapparat("Sony Apha IV", "K-101323", sonyObjektiv, sonyKarte);

            // // Test Speicherkartenwechsel
            // Speicherkarte neueKarte = new Speicherkarte("Kingston", "S-003", 2000);
            // kameras[0].WechselSpeichekarte(neueKarte);

            // kameras[0].Foto();

            // // Wie viele Fotos noch möglich?
            // System.Console.WriteLine("\nVerfügbare Fotos: " + kameras[0].AnzahlVerfuegbarenFotos());

            // System.Console.WriteLine(kameras[0].ToString());

        }
    }
}