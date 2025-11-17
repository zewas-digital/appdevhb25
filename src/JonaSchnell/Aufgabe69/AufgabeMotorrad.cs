namespace Appdevhb25.JonaSchnell.Aufgabe69
{
    public class AufgabeMotorrad
    {
        public static void Moto()
        {
            System.Console.WriteLine("Wieviele Kilometer dürfen es höchstens sein?");
            int kilometerInput = Convert.ToInt32(Console.ReadLine());
            var rnd = new Random();
            int kilometer = rnd.Next(0, kilometerInput);
            System.Console.WriteLine("Was für eine Farbe soll dein Auto haben?");
            string farbe = Console.ReadLine();
            System.Console.WriteLine("Was hast du für ein Kennzeichen?");
            string kennzeichen = Console.ReadLine();
            System.Console.WriteLine("Wiviel PS soll das Auto haben?");
            string leistungInput = Console.ReadLine();
            int leistung = Convert.ToInt32(leistungInput);
            Motorrad verkauftesMotorrad = new Motorrad(farbe, kennzeichen, kilometer, leistung, rnd.Next(5000, leistung * 100 + kilometer * 10));
            verkauftesMotorrad.Verkäufe();
        }
    }
}