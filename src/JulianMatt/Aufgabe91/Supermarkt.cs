namespace Appdevhb25.JulianMatt.Aufgabe91
{
    public class Supermarkt
    {
        public bool IsOpen = true;

        public int Registers = 5;

        List<Kasse> kasse = new List<Kasse>();

        public double TotalRevenueOfToday;

        public void HowManyRegistersAreOpened()
        {
            while (IsOpen == true)
            {
            System.Console.WriteLine("Wie viel Kassen sind gerade geöffnet");
            int registerOpened = Convert.ToInt32(Console.ReadLine());

            for ( int i = 0; i < registerOpened; i++)
            {
                kasse.Add(new Kasse());
                kasse[i].OpenedRegister();
                TotalRevenueOfToday += Kasse.TotallRevenueOfThisKassa;
            }

            System.Console.WriteLine($"\nDer Gesamtumsatz des Tages ist {TotalRevenueOfToday} Euro");

            OpenOrClose();
            System.Console.WriteLine();
            Console.Clear();
            }
        }

        public bool OpenOrClose()
        {
            System.Console.WriteLine("Wollen sie den Laden Schließen oder geöffnet lassen (Ja|Nein)");
            string input = Console.ReadLine().ToLower();

            if (input == "ja")
            {
                IsOpen = true;
            }
            else if (input == "nein")
            {
                IsOpen = false;
            }
            else
            {
                System.Console.WriteLine("Invalider Input der laden bleibt geöfnet");
            }

            return IsOpen;
        }
    }
}