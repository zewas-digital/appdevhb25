using System.Formats.Asn1;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe16
{
    public class HigherOrLower
    {
        public static void Start(int number)
        {

            Console.WriteLine("Rate meine Zahl");

            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int myNumber = Convert.ToInt32(Console.ReadLine() ?? string.Empty);



            while (myNumber != randomNumber)
            {

                int eingabe = Convert.ToInt32(Console.ReadLine() ?? string.Empty);



                if (eingabe < randomNumber)
                {
                    Console.WriteLine("Zu niedrig. Nochmal");
                }
                else if (eingabe > randomNumber)
                {
                    Console.WriteLine("Zu hoch. Nochmal");
                }
                else
                {
                    Console.WriteLine($"Du hast die Zahl erraten");
                }

            }
        }
    }
}
