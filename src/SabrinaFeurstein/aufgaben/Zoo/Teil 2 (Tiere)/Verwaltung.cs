namespace Appdevhb25.SabrinaFeurstein.aufgaben.zoo.teil2
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

            zoos[0].Gehege[0].TierHinzufuegen("Blümchen", Gattung.Kuh);
            zoos[0].Gehege[0].TierHinzufuegen("Gerda", Gattung.Kuh);
            zoos[0].Gehege[1].TierHinzufuegen("Hugo", Gattung.Storch);
            zoos[0].Gehege[1].TierHinzufuegen("Bryan", Gattung.Storch);
            zoos[0].Gehege[1].TierEntfernen("Bryan");

            foreach (Zoo zoo in zoos)
            {
                Console.WriteLine($"├── Zoo: {zoo}");
                foreach (Gehege gehege in zoo.Gehege)
                {
                    Console.WriteLine($"│{" ",3}├── Gehege: {gehege}");
                    foreach (Tier tier in gehege.Tiere)
                    {
                        Console.WriteLine($"│{" ",7}├── {tier}");
                    }
                    if (gehege.Tiere.Count == 0)
                        Console.WriteLine($"│{" ",7}├── (leer)");
                }
            }
        }
    }
}