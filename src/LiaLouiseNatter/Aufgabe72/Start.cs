using System.Security.Cryptography;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe72
{
    public class Start
    {
        public static void FotoapparatStart()
        {
            //Fotoapparat fotoapparat = new Fotoapparat();
            //fotoapparat.Modell = "hahahaha";

            /*
            Objektiv objektiv1 = new Objektiv("Canon");
            objektiv1.ObjektivPrinter();
            Objektiv objektiv2 = new Objektiv("Sony");
            objektiv2.ObjektivPrinter();
            Objektiv objektiv3 = new Objektiv("Canon EF");
            objektiv3.ObjektivPrinter();
            */

            Speicherkarte speicherkarte1 = new Speicherkarte(500);
            Objektiv objektiv = new Objektiv("Objektiv1");
            Objektiv objektiv2 = new Objektiv("Objektiv2");

            Fotoapparat Foto1 = new Fotoapparat();
            Foto1.speicherKarte = speicherkarte1;
            Foto1.Modell = "babababab";
            Foto1.Megapixel = 300;
            Foto1.objektiv = objektiv;
            Foto1.objektiv.ObjektivPrinter();
            Foto1.takePhoto();
            Foto1.objektiv = objektiv2;
            Foto1.takePhoto();

            Speicherkarte speicherkarte2 = new Speicherkarte(500);
            

            Fotoapparat Foto2 = new Fotoapparat();
            Foto2.speicherKarte = speicherkarte2;
            Foto2.Modell = "babababab";
            Foto2.Megapixel = 300;
            Foto2.objektiv = objektiv2;
            Foto2.objektiv.ObjektivPrinter();
            Foto2.takePhoto();


            


        }
    }
}