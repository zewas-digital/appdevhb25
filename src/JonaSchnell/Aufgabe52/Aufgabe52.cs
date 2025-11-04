namespace Appdevhb25.JonaSchnell.Aufgabe52
{
    public class Aufgabe52
    {
        public static void CalculateSundays()
        {
            DateTime today = new DateTime(2025, 10, 21);
            
            TimeSpan timespan = new TimeSpan(5, 0, 0, 0);

            for (int i = 0; i < 3; i++)
            {
                DateTime newDate = today.Add(timespan);

                System.Console.WriteLine(newDate.ToString());

                today = newDate;

                timespan = new TimeSpan(7, 0, 0, 0);
            }
        }
    }
}