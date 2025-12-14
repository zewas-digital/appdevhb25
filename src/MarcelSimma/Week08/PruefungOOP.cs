namespace Appdevhb25.MarcelSimma.Week08
{
    public class PruefungOOP
    {
        public static void Start()
        {
            Hund hund = new Hund("Bello", 3, "Labrador");
            Console.WriteLine($"Name: {hund.Name}, Alter: {hund.Alter}, Rasse: {hund.Rasse}");
        }
    }
}