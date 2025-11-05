using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe66
{
    public class TypischeEigenschaften
    {
        private double _size;

        public double Size
        {
            get { return _size; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("Du kannst nicht so wenig wiegen");
                }
                else
                {
                    _size = value;
                }
            }
        }
        private DateTime _birthday;

        public DateTime Birthday
        {
            get { return _birthday; }
            set
            {
                DateTime now = DateTime.Now;
                int AgeLimit = now.Year - 100;
                if (value.Year > now.Year - 100)
                {
                    System.Console.WriteLine("Dieses Alter ist ungültig");
                }
                else if (value.Year >= now.Year)
                {
                    System.Console.WriteLine("Du wärst noch nicht mahl geboren");
                }
                else
                {
                    _birthday = value;
                }
            }
        }

        public string Name;
        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("Du kannst nicht 0 kg wiegen");
                }
                else
                {
                    _weight = value;
                }
            }
        }

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