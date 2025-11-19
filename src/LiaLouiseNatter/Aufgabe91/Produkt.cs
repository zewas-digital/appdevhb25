namespace Appdevhb25.LiaLouiseNatter.Aufgabe91
{
    public class Produkt
    {
        public Dictionary<string, double> produkte = new Dictionary<string, double>()
            {
                { "Apfel", 0.49 },{ "Banane", 0.39 },{ "Milch 1L", 1.19 },{ "Brot", 2.49 },{ "Butter", 2.29 },
                { "Eier 10er", 3.29 },{ "Käse", 2.99 },{ "Tomaten", 1.49 },{ "Kartoffeln 1kg", 1.99 },{ "Nudeln 500g", 0.99 },
                { "Reis 1kg", 2.79 },{ "Mineralwasser 1.5L", 0.69 },{ "Cola 1L", 1.29 },{ "Orangensaft", 1.89 },
                { "Hähnchenbrust 1kg", 6.49 },{ "Hackfleisch 500g", 3.99 },{ "Pizza Tiefkühl", 2.49 },{ "Schokolade", 1.19 },
                { "Chips", 1.49 },{ "Shampoo", 2.79 }
            };
        
        public void PrintProdukte()
        {
            int counter = 0;
            System.Console.WriteLine($"Wilkommen im Spar");
            foreach(KeyValuePair<string, double> produkt in produkte)
            {
                counter++;
                
                System.Console.WriteLine($"Artikel: {produkt.Key} Preis: {produkt.Value}");
            }
        }

        public Produkt()
        {
            
        }
        
    }
}