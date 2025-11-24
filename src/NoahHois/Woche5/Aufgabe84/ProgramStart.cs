namespace Appdevhb25.NoahHois.Aufgabe84
{
    public class Program
    {
        public static void Start()
        {
            List<IGegenstand> objects = new();
            objects.Add(new Motorrad(100, 20_000, "Blau", "ABC123", 5));
            objects.Add(new Auto(4,"Grün", "TGJ829", 15_000));
            foreach (var v in objects)
            {
                System.Console.WriteLine(v.PrintObject());                
            }
        }
    }
}