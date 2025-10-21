using System.Net.Http.Headers;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe45
{
    public class CountLettersAndSymbols
    {
        public static void Start()
        {
            string text = "The quick brown fox jumps over the lazy dog. You can't get rid of me! Assign the address of number to a pointer.";

            int[] countSigns = new int[128];
            for (int i = 0; i < text.Length; i++)
            {
                char counting = text[i];
                countSigns[(int)counting]++;
            }
            for (int i = 32; i < countSigns.Length - 1; i++)
            {
                if (countSigns[i] > 0)
                {
                    Console.WriteLine(countSigns[i] + " '" + (char)i + "'");
                }
            }
        }
    }
}