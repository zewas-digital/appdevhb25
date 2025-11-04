using System;
using System.IO;
using System.Globalization;
using System.Runtime;

namespace Appdevhb25.JulianMatt.Aufgabe63
{
    public class ProccesNumbers
    {
        public static void Start63()
        {
            Computing();
        }

        public static void Computing()
        {
            int amountofNumbers = NumberApplier("Geben sie an wie viele Zahlen sie benutzen wollen: ");

            int[] numbers = new int[amountofNumbers];

            for (int i = 0; i < amountofNumbers; i++)
            {
                numbers[i] = NumberApplier("Geben sie ihre Zahl an: ");
            }

            int[] resultArray = ArrayOutgiver(numbers);

            System.Console.WriteLine("[" + resultArray[0] + ", " + resultArray[1] + "]");
        }

        public static int[] ArrayOutgiver(int[] numbers)
        {
            int minSave = 0;
            int posSave = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    minSave += 1;
                }
                else if (numbers[i] >= 0)
                {
                    posSave += numbers[i];
                }
            }
            int[] finishedSolution = new int[] { minSave, posSave };

            return finishedSolution;
        }

        public static int NumberApplier(string textInput)
        {

            bool isInteger;
            int result;
            do
            {
                Console.WriteLine(textInput);
                string input = Console.ReadLine();

                isInteger = int.TryParse(input, out result);

            } while (isInteger == false);

            return result;

        }
    }
}
