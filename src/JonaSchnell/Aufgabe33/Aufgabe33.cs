using System.Globalization;
using System.Security.Cryptography;

namespace Appdevhb25.JonaSchnell.Aufgabe33
{
    public class Aufgabe33
    {


        public static void Start33()
        {
            int[] numbers = new int[5];
            numbers[0] = RandomNumberGenerator.GetInt32(1, 100);
            numbers[1] = RandomNumberGenerator.GetInt32(1, 100);
            numbers[2] = RandomNumberGenerator.GetInt32(1, 100);
            numbers[3] = RandomNumberGenerator.GetInt32(1, 100);
            numbers[4] = RandomNumberGenerator.GetInt32(1, 100);
            int[] cloned = numbers;
            Console.WriteLine(cloned[0] + ", " + cloned[1] + ", " + cloned[2] + ", " + cloned[3] + ", " + cloned[4]);
        }
    }
}