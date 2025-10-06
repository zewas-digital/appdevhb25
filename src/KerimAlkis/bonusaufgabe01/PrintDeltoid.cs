using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Appdevhb25.KerimAlkis.Aufgabe00;

namespace Appdevhb25.KerimAlkis.Bonusaufgabe01
{
    public class PrintDeltoid
    {
        public static void Start(int hoehe)
        {
            int test2;
            if (hoehe % 2 == 0)
            {
                test2 = 1;
            }
            else { test2 = 0; }
            hoehe += test2;
            int breite = hoehe;
            for (int i = 0; i < hoehe; i++)
            {
                int hoehenhalfte = hoehe / 2;
                int breitenhalfte = (breite + 1) / 2;
                string zeile = "";

                for (int breitenZeichen = 1; breitenZeichen <= breite; breitenZeichen++)
                {
                    if (i == 0 || i == hoehe - 1)
                    {
                        if (breitenZeichen == breitenhalfte)
                        {
                            zeile += "X";
                        }
                        else zeile += ".";
                    }
                    else if (i == hoehenhalfte)
                    {
                        if (breitenZeichen == 1 || breitenZeichen == breite)
                        {
                            zeile += "X";
                        }
                        else { zeile += "."; }
                    }
                    else if (i < hoehenhalfte)
                    {
                        if (breitenZeichen == breitenhalfte + i || breitenZeichen == breitenhalfte - i)
                        {
                            zeile += "X";
                        }
                        else { zeile += "."; }
                    }
                    else if (i > hoehenhalfte)
                    {
                        int test = hoehe - i - 1;
                        if (breitenZeichen == breitenhalfte - test || breitenZeichen == breitenhalfte + test)
                        {
                            zeile += "X";
                        }
                        else { zeile += "."; }
                    }


                }
                Console.WriteLine(zeile);
            }


        }
    }
}