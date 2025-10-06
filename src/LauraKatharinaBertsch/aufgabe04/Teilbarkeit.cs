namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe04
{
    public class Teilbarkeit
    {
        public static void Start()
        {

            int intervallstart = 8;
            int intervallend = 14;
            int teiler = 3;
            Console.WriteLine("Teiler: " + teiler);
            Console.WriteLine("Intervallstart: " + intervallstart);
            Console.WriteLine("Intervallende: " + intervallend);
            for (int i = intervallstart; i <= intervallend; i++)
            {
                i = i + i;
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}