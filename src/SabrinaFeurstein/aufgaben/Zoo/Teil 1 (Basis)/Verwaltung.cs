namespace Appdevhb25.SabrinaFeurstein.aufgaben.zoo.teil1
{
    public class Verwaltung
    {
        public static void Start()
        {
            List<Zoo> zoos = [new Zoo("Tiergarten Dornbirn", 2022)];

            zoos[0].GehegeHinzufuegen("Alpenwiese");
            zoos[0].GehegeHinzufuegen("Ried");
            zoos[0].GehegeHinzufuegen("Terrarium (warm)");
            zoos[0].GehegeHinzufuegen("Dschungel");
            zoos[0].GehegeEntfernen("dschungel");

            foreach (Zoo zoo in zoos)
            {
                Console.WriteLine($"├── Zoo: {zoo}");
                foreach (Gehege gehege in zoo.Gehege)
                {
                    Console.WriteLine($"│{" ",3}├── Gehege: {gehege}");
                }
            }
        }
    }
}