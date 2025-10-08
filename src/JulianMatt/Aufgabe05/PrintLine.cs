using System;

namespace Appdevhb25.JulianMatt.Aufgabe05
{
    public class PrintLine
    {

        public static void Start05()
        {
            Console.WriteLine("Gebe ein Buchstabe ein");
            string Buchstabe = Console.ReadLine();
            Console.WriteLine("Gebe ine Zahl ein die sagt wie oft der Buchstabe geschrieben werden muss");
            int Anzahl = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= Anzahl; i++)
            {
                Console.Write(Buchstabe);
            }
        }
    }

}