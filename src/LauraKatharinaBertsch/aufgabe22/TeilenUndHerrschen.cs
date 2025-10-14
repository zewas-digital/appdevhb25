using System.Globalization;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe22
{
    public class TeilenUndHerrschen
    {
        public static void Start()
        {

            var number = 0;
            while (number <= 20)
            {
                Console.WriteLine(number);
                number++;
            }
            var number1 = 0;
            while (number1 <= 20)
            {
                var quotient = number1 / 5;
                Console.WriteLine(number1 + " / 5 = " + quotient);

                number1++;
            }
            var number2 = 0;
            while (number2 <= 20)
            {
                var quotient2 = number2 / 5.0;
                Console.WriteLine(number2 + "/ 5 = " + quotient2);
                number2++;
            }





        }
    }
}