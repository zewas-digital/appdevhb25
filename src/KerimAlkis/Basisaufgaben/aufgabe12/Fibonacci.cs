using System.Globalization;

namespace Appdevhb25.KerimAlkis.Aufgabe12
{
    public class Fibonacci
    {
        public static void Start()
        {
            int zahl;
            do
            {
                Console.Clear();
                System.Console.Write("Zahl: ");
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    zahl = inputNumber; break;
                }
            } while (true);
            System.Console.WriteLine();




            int ersteSumme = 1;
            int zweiteSumme = 0;

            int neueSumme = 0;
            
            for (int i = 0; i <= zahl; i++)
            {
                if (i < 2)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    neueSumme = ersteSumme + zweiteSumme;
                    Console.WriteLine(neueSumme);
                    zweiteSumme = ersteSumme;
                    ersteSumme = neueSumme;
                }
            }
        }
    }
}