using System; 
namespace Appdevhb25.SheilaMayJaro.Aufgabe57
{
    public class Square
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 57) Quadrieren");

            using (StreamReader Square = new StreamReader(@"C:\Users\JASHE\Documents\DigitalCampus2025\appdevhb25\src\SheilaMayJaro\Aufgabe57\input.txt"))
            {
                string? temp = Square.ReadLine();
                int number = Convert.ToInt32(temp);

                // while (temp != null)
                // {
                //     int result = 0;
                //     result = number * number;
                //     temp = Square.ReadLine();
                //     number = Convert.ToInt32(temp);
                //     System.Console.WriteLine(result);
                // }
                
                using (StreamWriter SquareResults = new StreamWriter(@"C:\Users\JASHE\Documents\DigitalCampus2025\appdevhb25\src\SheilaMayJaro\Aufgabe57\output.txt"))
                {
                    while (temp != null)
                {
                    int result = 0;
                    result = number * number;
                    temp = Square.ReadLine();
                    number = Convert.ToInt32(temp);
                   SquareResults.WriteLine(result);
                }
                }
                
            }
        }
    }
}