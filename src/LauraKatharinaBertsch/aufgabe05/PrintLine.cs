

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe05
{
    public class PrintLine
    {
        public static void Start()
        {

            int numberOfSigns = 5;
            Console.WriteLine("Anzahl der Zeichen: " + numberOfSigns);
            for (int i = numberOfSigns; i <= numberOfSigns; i++)
            {
                Console.Write("x");
            }
        }
    }
}