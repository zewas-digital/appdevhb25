using System.Drawing;
using System.Runtime.Serialization.Formatters;

namespace Appdevhb25.JonaSchnell.Aufgabe11
{
    public class Aufgabe11

    {

        public static void Start11()
        {
            Console.WriteLine("Welche Zahl soll ich testen?");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number; i++)
                if (number / i == number)
                {
                    Console.WriteLine("Das ist eine Primzahl");
                }
                else if (number / i == 1)
                {
                    Console.WriteLine("Das ist eine Primzahl");
                }
                else
                {
                    Console.WriteLine("Das ist keine Primzahl");
                }
        }
    }
}