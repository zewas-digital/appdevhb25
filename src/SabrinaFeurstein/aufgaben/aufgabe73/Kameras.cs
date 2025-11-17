namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe73
{
    public class Kameras
    {
        public static void Start()
        {
            Fotoapparat[] fotoapparate =
            [
                new Fotoapparat("Nikon D850", "F335HF9"),
                new Fotoapparat("Sony Vlog-Kamera ZV-1", "346HJ78"),
                new Fotoapparat("Canon EOS 250D Kit", "KJ987L2")
            ];
            
            Speicherkarte speicherkarte1 = new Speicherkarte("Hama 55377", "HGJ54G", 32);
            Speicherkarte speicherkarte2 = new Speicherkarte("Sandisk Ultra SDXC Karte", "47HKGL", 64);

            Objektiv objektiv2 = new Objektiv("Sigma MC-11", "G6H55K", 70);
            Objektiv objektiv1 = new Objektiv("Walimex pro T2", "34VVR7", 55);

            for (int i = 0; i < fotoapparate.Length; i++)
            {
                fotoapparate[i].WechsleSpeicherkarte(speicherkarte1);
                fotoapparate[i].WechsleObjektiv(objektiv1);
                Console.WriteLine(fotoapparate[i]);
            }
            
            Console.WriteLine();
            fotoapparate[0].SpeicherAnzeigen();
            fotoapparate[0].WechsleSpeicherkarte(speicherkarte2);
            fotoapparate[0].SpeicherAnzeigen();

            fotoapparate[0].ObjektivAnzeigen();
            fotoapparate[0].WechsleObjektiv(objektiv2);
            fotoapparate[0].ObjektivAnzeigen();

            fotoapparate[0].Foto();
            fotoapparate[0].Foto();
            Console.WriteLine();
            fotoapparate[0].AnzahlVerfuegbarerFotos();
        }
    }
}