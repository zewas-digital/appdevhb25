using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe68
{
    public class Intro
    {
        public static void Start()
        {

            Fotoapparat[] fotoapparats = new Fotoapparat[3];
            fotoapparats[0] = new Fotoapparat(8, 300, "Lochkamera", "Canon", 20);
            fotoapparats[1] = new Fotoapparat(8, 300, "Lochkamera", "Canon", 20);
            fotoapparats[2] = new Fotoapparat(8, 300, "Lochkamera", "Canon", 20);

            int i = 0;
            foreach (Fotoapparat fotoapparat in fotoapparats)
            {
                i++;
                Console.WriteLine();
                fotoapparat.Print();
                if (i == 3)
                {
                    fotoapparat.TakePhoto();
                }
            }


        }
    }
}