using System.ComponentModel;

namespace Appdevhb25.JulianMatt.BetriebsAufgabe01
{
    public class WeihnachtsBaum01
    {

        public static void BonusStart03()
        {
            int baumArt = Abfrage();
            if (baumArt == 1)
            {
                SpikeTree();
            }
            else if (baumArt == 2)
            {
                TriangleTree();
            }
        }

        public static int Abfrage()
        {
            Console.WriteLine("Choose your Tree if you want Tree 1 type 1 if you want Tree 2 type 2");
            int baum = Convert.ToInt32(Console.ReadLine());
            if (baum < 2)
            {
                return baum;
            }
            return 0;

        }

        public static void SpikeTree()
        {

        }

        public static void TriangleTree()
        {

        }
    }
}