using System;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.NoahHois.Aufgabe14
{
    public class Faktorial
    {
        public static void Aufgabe14()
        {
            for (int i = 1; i <= 20; i++)
            {
                long fakult = 1;
                for (int x = 1; x <= i; x++)
                {
                    fakult = x * fakult;

                }
                //  Console.WriteLine(i + "! = " + fakult);                                 Aufgabe 20
                Console.WriteLine(String.Format("{0, -2}! = {1,25}", i, fakult));           // Aufgabe 21
            }   
        }
    }
}