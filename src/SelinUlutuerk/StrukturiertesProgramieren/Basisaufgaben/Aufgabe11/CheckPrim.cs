using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe11
{
    class CheckPrim
    {
        public static string StartCheckPrim(int zahl)
        {
            for (int y = 2; y < zahl; y++)
                {
                    if (zahl % y == 0)
                    {
                        return "-1";
                    }
                }
            return "+1";
        }
    }
}