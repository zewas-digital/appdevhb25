using System;

namespace Appdevhb25.SabrinaFeurstein.uebung
{
    public class aufgabe11
    {
        public static string CheckPrim(int zahl)
        {
            if (zahl == 1)
            {
                return "-1";
            }
            if (zahl == 2)
            {
                return "+1";
            }
            else
            {
                for (int i = 2; i < zahl - 1; i++)
                {
                    if (zahl % i == 0)
                    {
                        return "-1";
                    }
                }
            }
            return "+1";
        }
    }
}