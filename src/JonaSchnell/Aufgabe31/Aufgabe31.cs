using System.Collections;
using System.Security.Cryptography;

namespace Appdevhb25.JonaSchnell.Aufgabe31
{
        public class Aufgabe31
    {
        public static void Start31()
        {
            int[] numbers = new int[5];
            numbers[0] = RandomNumberGenerator.GetInt32(1, 100);
            numbers[1] = RandomNumberGenerator.GetInt32(1, 100);
            numbers[2] = RandomNumberGenerator.GetInt32(1, 100);
            numbers[3] = RandomNumberGenerator.GetInt32(1, 100);
            numbers[4] = RandomNumberGenerator.GetInt32(1, 100);
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Die Summe der Zahlen ist: " + sum);
            int averrage = sum / numbers.Length;
            Console.WriteLine("Der Durchschnitt der Zahlen ist: " + averrage);
            int highest = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < highest)
                {
                    highest = numbers[i];
                }
            }
            Console.WriteLine("Die kleinste Zahl ist: " + highest);
            int lowest = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > lowest)
                {
                    lowest = numbers[i];
                }
            }
            Console.WriteLine("Die grösste Zahl ist: " + lowest);
            Console.WriteLine("Die Zahlen sind:" + numbers[0] + ", " + numbers[1] + ", " + numbers[2] + ", " + numbers[3] + ", " + numbers[4]);
        }
    }
}