namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe91
{
    public class Supermarkt
    {
        public static Dictionary<string, decimal> products = new Dictionary<string, decimal>();
        public static void Product()
        {
            products.Add("Milch", 1.19m);
            products.Add("Brot", 2.49m);
            products.Add("Butter", 2.29m);
            products.Add("Äpfel", 2.99m);
            products.Add("Nudeln", 0.99m);
            products.Add("Eier", 2.69m);
            products.Add("Käse", 2.49m);
            products.Add("Tomaten", 3.49m);
            products.Add("Schokolade", 1.09m);
            products.Add("Schinken", 1.49m);

            Console.WriteLine("Das sind die verfügbaren Produkte:");
            foreach (var product in products)
            {
                Console.WriteLine($"Produktname: {product.Key,-10} Preis: {product.Value}€");
            }

            Console.WriteLine();
        }
    }
}