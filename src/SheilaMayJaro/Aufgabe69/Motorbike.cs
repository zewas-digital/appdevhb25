using System.Globalization;

namespace Appdevhb25.SheilaMayJaro.Aufgabe69
{
    public class Aufgabe69
    {
public static void Start()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            System.Console.WriteLine("Aufgabe 69)");
            Motorbike motorbike = new Motorbike("schwarz", 40.5, 10_000);
            Motorbike motorbike1 = new Motorbike("gelb", 50, 20_000);
            Motorbike motorbike2 = new Motorbike("orange", 55, 15_500);
            motorbike.PrintDataSheet();
            Motorbike usedMotorbike = new Motorbike("braun", 23, 10_000, 236_741);
            Motorbike usedMotorbike1 = new Motorbike("rot", 47, 4_050, 236_741);
            Motorbike usedMotorbike2 = new Motorbike("blau", 59, 3_400, 236_741);
            Motorbike usedMotorbike3 = new Motorbike("grau", 38, 12_400, 236_741);
            System.Console.WriteLine();
            usedMotorbike.PrintDataSheet();
            double averageSalesPerMotorbike = Motorbike.CalculateAverageSalesPerMotorbike();
            System.Console.WriteLine($"Der Durchschnittsumsatz liegt bei {averageSalesPerMotorbike.ToString("C", CultureInfo.GetCultureInfo("de-DE"))}");
            
             
        }
    }
}