using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Appdevhb25.JulianMatt.Bonusaufgabe04
{
    public class HigherOrLower
    {
        static int randomNumber;
        public static void BonusStart04()
        {
            ChooseRange();
            NumberCheck();
        }

        public static void ChooseRange()
        {
            Console.WriteLine("Wilkommen zu Higher or Lower gebe doch als erstes mal den Bereich an in dem du spielen möchtest");
            int range = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            randomNumber = random.Next(1, range);
            Console.WriteLine("Der Zahlen Bereich ist 1 bis " + range + " Welche Zahl habe ich mir wohl ausgesucht?");
        }

        public static void NumberCheck()
        {

            while (true)
            {
                Console.WriteLine("Nun kannst du eine Zahl zum raten eingeben");
                int numberCheck = Convert.ToInt32(Console.ReadLine());
                if (numberCheck == randomNumber)
                {
                    Console.WriteLine("Du hast es erraten.");
                    break;

                }
                if (numberCheck < randomNumber)
                {
                    Console.WriteLine("Die gesucht nummer ist größer");
                }
                if (numberCheck > randomNumber)
                {
                    Console.WriteLine("Die gesuchte nummer ist kleiner");
                }
                //Console.WriteLine("rande Zahl war " + randomNumber);
            }
            
        }
    }
}