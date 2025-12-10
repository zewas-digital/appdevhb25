namespace Appdevhb25.SabrinaFeurstein.aufgaben.zoo.teil3
{
    public class Verwaltung
    {
        public static void Start()
        {
            Futter heu = new Futter("Heu", "kg", 0.5);
            Futter wasser = new Futter("Wasser", "L", 0.2);
            Zoo zoo = new Zoo("Tiergarten Dornbirn", 2022);

            zoo.GehegeHinzufuegen("Alpenwiese");
            zoo.GehegeHinzufuegen("Ried");
            zoo.GehegeHinzufuegen("Terrarium (warm)");
            zoo.GehegeHinzufuegen("Dschungel");
            zoo.GehegeEntfernen("dschungel");

            zoo.Gehege[0].TierHinzufuegen("Blümchen", Gattung.Kuh);
            zoo.Gehege[0].TierHinzufuegen("Gerda", Gattung.Kuh);
            zoo.Gehege[1].TierHinzufuegen("Hugo", Gattung.Storch);
            zoo.Gehege[1].TierHinzufuegen("Bryan", Gattung.Storch);
            zoo.Gehege[1].TierEntfernen("Bryan");

            zoo.Gehege[0].Tiere[0].FutterHinzufuegen(heu, 12);
            zoo.Gehege[0].Tiere[0].FutterHinzufuegen(wasser, 50);
            zoo.Gehege[0].Tiere[1].FutterHinzufuegen(heu, 15);
            zoo.Gehege[0].Tiere[1].FutterHinzufuegen(wasser, 55);
            zoo.Gehege[1].Tiere[0].FutterHinzufuegen(wasser, 2);

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

            Console.WriteLine();
            zoo.FutterbedarfAusgeben();
        }
    }
}