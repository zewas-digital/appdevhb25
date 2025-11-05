using System.Diagnostics.Contracts;
using System.Security.Cryptography;

namespace Appdevhb25.NoahHois.Aufgabe59
{
    public class Inventur
    {
        public static void Start()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\NOHO\Documents\VSCode Projekte\appdevhb25\src\NoahHois\Woche4\Aufgabe59\Input.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\NOHO\Documents\VSCode Projekte\appdevhb25\src\NoahHois\Woche4\Aufgabe59\Output.txt"))
                {
                    decimal sumOfGroceriesPrize = 0;
                    decimal averageOfGroceries = 0;
                    decimal mostExpensiveItem = 0;
                    decimal cheapestItem = 1;
                    decimal sumOfKg = 0;
                    decimal sumOfL = 0;
                    decimal sumOfPieces = 0;
                    string nameOfMostExpensiveItem = "";
                    string nameOfCheapestItem = "";
                    string? line = reader.ReadLine();
                    string[] parts = line.Split('\t');
                    Console.WriteLine($"┌{new string('─', 20)}┬{new string('─', 16)}┬{new string('─', 11)}┐");
                    Console.WriteLine($"{string.Format("│{0, -20}", parts[0])}│ {string.Format("{0, -15}", parts[1])}│ {string.Format("{0, -8}", parts[2])}  │");
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        // Formatiertes Ausgeben
                        Console.WriteLine($"├{new string('─', 20)}┼{new string('─', 16)}┼{new string('─', 11)}┤");
                        parts = line.Split('\t');
                        decimal prize = Convert.ToDecimal(parts[2].Replace('.', ','));
                        Console.WriteLine($"│{string.Format("{0, -20}", parts[0])}│ {string.Format("{0, -15}", parts[1])}│ {string.Format("{0, -8:0.00}", prize)}  │");

                        if (line == "Batterien AA	4 Stück	3.99")
                        {
                            if (line != "Batterien AA	4 Stück	3.99")
                            {
                                Console.WriteLine($"├{new string('─', 20)}┼{new string('─', 16)}┼{new string('─', 11)}┤");
                            }
                            else
                            {
                                Console.WriteLine($"└{new string('─', 20)}┴{new string('─', 16)}┴{new string('─', 11)}┘");
                            }
                        }

                        // Mengen
                        string[] amoutAndUnit = parts[1].Split();
                        decimal amount = Convert.ToDecimal(amoutAndUnit[0]);
                        string unit = amoutAndUnit[1];
                        if (unit == "kg")
                        {
                            sumOfKg += amount;
                        }
                        else if (unit == "g")
                        {
                            sumOfKg += amount / 1000;
                        }
                        if (unit == "l")
                        {
                            sumOfL += amount;
                        }
                        else if (unit == "ml")
                        {
                            sumOfL += amount / 1000;
                        }
                        if (unit == "Stück")
                        {
                            sumOfPieces += amount;
                        }
                        else if (unit == "Beutel")
                        {
                            sumOfPieces += amount;
                        }

                        // Berechnen von der Gesamtsumme
                        decimal groceriesPrize = Convert.ToDecimal(parts[2].Replace('.', ','));
                        sumOfGroceriesPrize += groceriesPrize;

                        // Berchenen des Durchschnitts
                        averageOfGroceries = sumOfGroceriesPrize / 30;

                        // teuerster Artikel
                        if (groceriesPrize >= mostExpensiveItem)
                        {
                            mostExpensiveItem = groceriesPrize;
                            nameOfMostExpensiveItem = parts[0];
                        }
                        // billigster Artikel
                        if (groceriesPrize < cheapestItem)
                        {
                            cheapestItem = groceriesPrize;
                            nameOfCheapestItem = parts[0];
                        }

                        // Nächste Zeile lesen
                        line = reader.ReadLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Kilogram Anzahl: " + sumOfKg);
                    Console.WriteLine("Liter Anzahl: " + sumOfL);
                    Console.WriteLine("Stück Anzahl: " + sumOfPieces);
                    Console.WriteLine("Summe Insgesamt: " + sumOfGroceriesPrize);
                    Console.WriteLine("Der Durchschnitt beträgt: " + averageOfGroceries);
                    Console.WriteLine("Der Teuerste Artikel: " + nameOfMostExpensiveItem + " " + mostExpensiveItem);
                    Console.WriteLine("Der billigste Artikel: " + nameOfCheapestItem + " " + cheapestItem);
                }
            }
        }
    }
}