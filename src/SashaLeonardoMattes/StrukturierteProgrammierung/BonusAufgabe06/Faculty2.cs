using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.BonusAufgabe06
{

    public class Faculty2
    {

        public static void StartFaculty2()
        {
            Console.WriteLine("----------Aufgabe 20----------");


            long faculty = 1;

            for (int i = 1; i < 21; i++)
            {
                faculty *= i;
                Console.WriteLine("{0,3}! = {1,20}", i, faculty); //erste zahl in geschwungen Klammern bezieht sich auf Varibale 2. auf Breite
            }

        }

    }
}
