namespace Appdevhb25.LiaLouiseNatter.Aufgabe69
{
    public class MotorradStart
    {
        public static void Start()
        {
            Motorrad m1 = new Motorrad(-100, "red", 200, 13000, "At123456");
            Motorrad m2 = new Motorrad("blue", 180, 15000, "Bt654321");
            Motorrad m3 = new Motorrad(300, "black", 220, 17000, "Ct789012");
            Motorrad m4 = new Motorrad("green", 160, 14000, "Dt345678");

            m4.Kilometerstand = -1000;
            System.Console.WriteLine($"Produzierte Motorräder: {Motorrad.AnzVerkaufteMotorraeder}");
            System.Console.WriteLine($"Durchschnittlicher Umsatz pro Produzierten Motorrad: {Motorrad.BerechneDurchschnittsUmsatz()}");
            System.Console.WriteLine("----------------------------------------------");

            
        }
    }
}