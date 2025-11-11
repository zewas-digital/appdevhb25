using System; 
namespace Appdevhb25.SheilaMayJaro.Aufgabe66
{
    public class Information
    {
        public double Height;
        public DateTime Birthday;
        public string? Name;

        public string? Familyname; 
        public double Weight;

        public void PrintInformations()
        {
            System.Console.WriteLine($"Vorname: {Name,15}");
            System.Console.WriteLine($"Nachname: {Familyname,14}");
            System.Console.WriteLine($"Größe: {Height,16}m");
            System.Console.WriteLine($"Geburtstag: {Birthday.ToString("d"),12}");
            System.Console.WriteLine($"Gewicht: {Weight,12} kg");

        }
        public void PrintInformations(string Name, string Familyname, double Height, double Weight, DateTime Birthday)
        {
            System.Console.WriteLine($"Vorname: {Name,15}");
            System.Console.WriteLine($"Nachname: {Familyname,14}");
            System.Console.WriteLine($"Größe: {Height,16}m");
            System.Console.WriteLine($"Geburtstag: {Birthday.ToString("d"),12}");
            System.Console.WriteLine($"Gewicht: {Weight,12} kg");
        }
        public void CalculateAge(DateTime Birthday)
        {
            //DateTime - DateTime = Timespan 
            DateTime moment = DateTime.Now;
            int age = moment.Year - Birthday.Year;
            System.Console.WriteLine($"Alter: {age,11} Jahre");
        }

    }
}
