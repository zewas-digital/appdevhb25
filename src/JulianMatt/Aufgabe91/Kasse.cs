using System.Collections;

namespace Appdevhb25.JulianMatt.Aufgabe91
{
    public class Kasse
    {
        Dictionary<string, double> WarenkorpDict = new Dictionary<string, double>();

        public static int HowManyCustomers;

        public static double TotallRevenueOfThisKassa;

        public void OpenedRegister()
        {
            List<Warenkorb> warenkorp = new List<Warenkorb>();

            System.Console.WriteLine("Her oder Frau Kassiererin wie viel Kunden sind bie ihnen angestellt");
            HowManyCustomers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < HowManyCustomers; i++)
            {
                warenkorp.Add(new Warenkorb());
                warenkorp[i].FillWarenkorb();

                WarenkorpDict.Add(warenkorp[i].NameOfTheOwnerOfWarenkorp, warenkorp[i].TotalPriceOfWarenkorb);
                System.Console.WriteLine();
                System.Console.WriteLine("\n\n\n\n");
            }


            foreach(var item in WarenkorpDict)
            {
                TotallRevenueOfThisKassa += item.Value;
                System.Console.WriteLine($"Der Kunde {item.Key} hat {item.Value} Euro Ausgegeben");
                System.Console.WriteLine();
            }

            System.Console.WriteLine($"Der Umsatz ist {TotallRevenueOfThisKassa}");
        }

    }


}