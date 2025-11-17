namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe69
{
    public class Intro
    {
        public static void Start()
        {


            Motorrad[] motorräder = new Motorrad[3];
            motorräder[0] = new Motorrad(0, "weiß", 100, 10_000, "AT123");
            motorräder[1] = new Motorrad(0, "weiß", 100, 10_000, "AT123");
            motorräder[2] = new Motorrad(0, "weiß", 100, 10_000, "AT123");
            int i = 0;
            foreach (Motorrad motorrad in motorräder)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine();
                    motorrad.PrintAlt();
                    Motorrad.AnzahlDerProduziertenMotorräder++;
                    Motorrad.Umsatz = Motorrad.Umsatz + motorrad.Kaufpreis;

                }
                else
                {
                    Console.WriteLine();
                    motorrad.PrintNeu();
                    Motorrad.AnzahlDerProduziertenMotorräder++;
                    Motorrad.Umsatz = Motorrad.Umsatz + motorrad.Kaufpreis;
                }
                i++;
            }
            Motorrad.PrintAnzahlDerProduziertenMotorräder();
            Motorrad.PrintUmsatz();
            Console.WriteLine("Der durchschnittliche Umsatz: " + Motorrad.BerechneDurschnittsumsatz());
        }
    }
}