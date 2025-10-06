using System;
// See https://aka.ms/new-console-template for more information

namespace Appdevhb25.SashaLeonardoMattes
{
    public static class Helper
    {
        public static int checkUserInputInteger()
        {
            bool checkInput;
            int result;
            do
            {
                checkInput = int.TryParse(Console.ReadLine(), out result);

                if (checkInput == false)
                {
                    Console.WriteLine("Bitte nur Ganzzahlen eingeben");
                }
            } while (checkInput == false);

            return result;
        }


        public static char checkUserInputChar()
        {
            bool checkInput;
            char result;
            do
            {
                checkInput = char.TryParse(Console.ReadLine(), out result);

                if (checkInput == false)
                {
                    Console.WriteLine("Bitte nur ein Zeichen eingeben");
                }
            } while (checkInput == false);

            return result;
        }

    }
}

