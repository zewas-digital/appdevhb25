
namespace Appdevhb25.LiaLouiseNatter.Aufgabe66
{
    public class Personen()
    {
        public float Height;
        public DateTime Brithday;
        public string Name;
        public float Weight;

        public void Print()
        {
            System.Console.WriteLine($"Göße: {Height}\nGeburtsdatum: {Brithday}\nName: {Name}\nGewicht: {Weight}");
        }
        
        public void GetBirthday()
        {
            var today = DateTime.Today;
            var age = today.Year - Brithday.Year;
            if (Brithday.Date > today.AddYears(-age)) age--;
            System.Console.WriteLine($"{Name} is {age} Years Old.");
        }

    }
}
