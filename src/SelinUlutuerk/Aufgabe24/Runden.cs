using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe24
{
    class Runden
    {
        public static double round(double zahl, int nachkommastelle)
        {
            double faktor = 1;

            for (int i = 0; i < nachkommastelle; i++)
            {
                faktor *= 10;
            }

            double verschoben = faktor * zahl;
            double rest = verschoben - (int)verschoben;

            bool aufrunden = rest >= 0.5;

            int ganz = (int)verschoben;
            if (aufrunden)
            {
                ganz += 1;
            }

            return ganz / faktor;
        }
    }
}