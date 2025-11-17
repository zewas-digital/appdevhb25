namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe59
{
    public class Inventur
    {
        public static void Start()
        {
            decimal mostExpensive = 0;
            decimal cheapest = 2;
            decimal average = 0;
            decimal totalValue = 0;

            string input = "/home/laura/Documents/appdevhb25/src/LauraKatharinaBertsch/aufgabe59/input.txt";
            using (StreamReader reader = new StreamReader(input))
            {
                string output = "/home/laura/Documents/appdevhb25/src/LauraKatharinaBertsch/aufgabe59/output.txt";
                using (StreamWriter writer = new StreamWriter(output))
                {
                    string line = reader.ReadToEnd();
                    string[] rows = line.Split('\n');
                    string[] columns = rows[0].Split("  ");

                    string mostExpensiveProduct = "";
                    string cheapestProduct = "";

                    for (int i = 0; i < rows.Length; i++)
                    {
                        columns = rows[i].Split("  ");

                        string productName = columns[0];
                        int amount = Convert.ToInt32(columns[1]);
                        decimal price = Convert.ToDecimal(columns[2]);

                        if (price > mostExpensive)
                        {
                            mostExpensive = price;
                            mostExpensiveProduct = productName;
                        }
                        if (price < cheapest)
                        {
                            cheapest = price;
                            cheapestProduct = productName;
                        }
                        totalValue = totalValue + amount * price;
                        average = average + price;
                    }
                    writer.WriteLine("Das teuerste Produkt ist: " + mostExpensiveProduct);
                    writer.WriteLine("Das billigste Produkt ist: " + cheapestProduct);
                    writer.WriteLine("Der Durchschnittspreis aller Produkte ist: " + Math.Round(average / rows.Length, 2));
                    writer.WriteLine("Der Endwert aller Produkte ist: " + totalValue);
                }
            }
        }
    }
}




