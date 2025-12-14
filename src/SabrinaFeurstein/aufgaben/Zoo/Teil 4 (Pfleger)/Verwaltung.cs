namespace Appdevhb25.SabrinaFeurstein.aufgaben.zoo.teil4
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

            zoo.PflegerHinzufuegen("Jane Austin");
            zoo.PflegerHinzufuegen("Jackie Taylor");

            zoo.Pfleger[0].GehegeZuordnen(zoo.Gehege[0]);
            zoo.Pfleger[1].GehegeZuordnen(zoo.Gehege[1]);
            zoo.Pfleger[1].GehegeZuordnen(zoo.Gehege[2]);

            Console.WriteLine($"├── Zoo: {zoo}");
            foreach (Gehege gehege in zoo.Gehege)
            {
                Console.Write($"│{" ",3}├── Gehege: {gehege} | Pfleger: ");
                bool gehegeHatPfleger = false;
                foreach (Pfleger pfleger in zoo.Pfleger)
                {
                    foreach (Gehege pflegerGehege in pfleger.Gehege)
                    {
                        int i = 0;

                        if (pflegerGehege == gehege && i != 0)
                            Console.Write($", {pfleger}");

                        else if (pflegerGehege == gehege)
                        {
                            Console.Write(pfleger);
                            i++;
                            gehegeHatPfleger = true;
                        }
                    }
                }
                if (!gehegeHatPfleger)
                    Console.Write("(Keine Zuweisung)");

                Console.WriteLine();

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