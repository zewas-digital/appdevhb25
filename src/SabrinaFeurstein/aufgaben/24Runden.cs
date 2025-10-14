using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{
    public class Runden

    {
        public static double Round(double zahl, int kommastellen)
        {
            double faktor = Math.Pow(10, kommastellen);
            double nummer = zahl * faktor;

            if (nummer >= 0)
            {
                nummer = (int)(nummer + 0.5);
            }
            else
            {
                nummer = (int)(nummer - 0.5);
            }

            return nummer / faktor;
        }
    }
}