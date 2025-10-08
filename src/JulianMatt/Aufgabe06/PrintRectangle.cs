using System;

namespace Appdevhb25.JulianMatt.Aufgabe06
{
    public class PrintRectangle
    {

        public static void Start06()
        {
            Console.WriteLine("Gebe ein Buchstabe ein");

            string Buchstabe = Console.ReadLine();

            Console.WriteLine("Gebe eine Zahl ein die sagt wie oft der Buchstabe geschrieben werden muss");

            int Anzahl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gebe eine Zahl an die sagt wie oft das alles wiederholt werden muss");
           
            int hoehe = Convert.ToInt32(Console.ReadLine());



            for (int g = 0; g <= hoehe; g++)
            {
                for (int i = 0; i <= Anzahl; i++)
                {
                    Console.Write(Buchstabe);
                }
                Console.WriteLine("");
            }
        }
    }

}