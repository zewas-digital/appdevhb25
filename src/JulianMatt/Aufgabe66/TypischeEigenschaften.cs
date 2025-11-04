using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe66
{
    public class TypischeEigenschaften
    {
        public double Size;
        public DateTime Birthday;
        public string Name;
        public double Weight;


        public void PrintSize()
        {
            System.Console.WriteLine(Size);
        }
        public void PrintBirthday()
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            System.Console.WriteLine(Birthday.ToString("d MMM yyyy"));
        }
        public void PrintName()
        {
            System.Console.WriteLine(Name);
        }
        public void PrintWeight()
        {
            System.Console.WriteLine(Weight);
        }

        public void Print()
        {
            

            PrintSize();
            PrintBirthday();
            PrintName();
            PrintWeight();


        }
        
        public void AgeCalculator()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - Birthday.Year;

            if (today.Month < Birthday.Month || today.Month == Birthday.Month && today.Day < Birthday.Day)
            {
                age -= 1;
            }
            
            System.Console.WriteLine(Name + " ist " + age + " Jahre alt");
        
        }
    }
}