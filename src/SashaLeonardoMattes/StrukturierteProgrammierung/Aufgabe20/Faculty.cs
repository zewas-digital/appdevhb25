using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe20
{

    public class Faculty
    {

        public static void StartFaculty()
        {
            Console.WriteLine("----------Aufgabe 20----------");


            long faculty = 1;

            for (int i = 1; i < 21; i++)
            {
                faculty *= i;
                Console.WriteLine(i + "! = " + faculty);
            }

        }

    }
}
