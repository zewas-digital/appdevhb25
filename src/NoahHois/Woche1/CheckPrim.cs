using System;

namespace Appdevhb25.NoahHois.Aufgabe11
{
    public class CheckPrim
    {
        public static int Aufgabe11(int zahl)
        {

            if (zahl == 2)
            {
                return 1;
            }
            else if (zahl == 1 || zahl == 0)
            {
                return -1;
            }
            else
            {
                 for (int p = 2; p < zahl; p++)
                {
                    if (zahl % p == 0)
                    {
                        return -1;
                    }
                }
                return 1;
            }
        }
    }
}