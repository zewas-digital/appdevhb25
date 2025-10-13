using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe6
{
    public class PrintRectangle
    {
         public static void Print_Rectangel(int zeilen, int spalten)
            {
                for (int y = 0; y > zeilen; y++)
                {
                    for (int x = 0; x < spalten; x++)
                    {
                        System.Console.WriteLine("*");
                    }
                }
            
            }
    }
}