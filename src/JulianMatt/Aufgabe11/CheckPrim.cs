using System;
using System.Runtime.CompilerServices;

namespace Appdevhb25.JulianMatt.Aufgabe11
{
    public class CheckPrim
    {

        public static int IstPrime(int zahl)
        {
            Console.WriteLine("Geben sie eine Zahl ein");

            if (zahl == 1 || zahl == 0)
            {
                return -1;
            }
            else if (zahl == 2)
            {
                return 1;
            }
            else
            {

                for (int i = 2; i < zahl; i++)
                {
                    if (zahl % i == 0)
                    {
                        return 1;
                    }
                }
                return -1;

            }


        }
    }
}



public class Test
{

    public static void IstPrime02()
    {
        Console.WriteLine("Geben sie eine Zahl ein");
        int zahl = Convert.ToInt32(Console.ReadLine());
        int result = 0;

        if (zahl == 1 || zahl == 0)
        {
            result = -1;
        }
        else if (zahl == 2)
        {
            result = 1;
        }
        else
        {

            for (int i = 2; i < zahl; i++)
            {
                if (zahl % i == 0)
                {
                    result = -1;
                    break;
                }
                else
                {
                    result = 1;
                }

            }
        }
        Console.WriteLine(result);

    }


}
