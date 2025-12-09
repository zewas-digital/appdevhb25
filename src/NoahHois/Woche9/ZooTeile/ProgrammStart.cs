namespace Appdevhb25.NoahHois.ZooTeile
{
    public class ProgrammStart
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Wildpark", 1990);
            Gehege g1 = new Gehege("Tropisch");
            Gehege g2 = new Gehege("Alpen");
            Gehege g3 = new Gehege("Meer");
            Gehege g4 = new Gehege("Wald");
            Gehege g5 = new Gehege("Wüste");
            Gehege g6 = new Gehege("Ried");
            Gehege g7 = new Gehege("Luft");
            zoo.GehegeHinzufügen(g1);
            zoo.GehegeHinzufügen(g2);
            zoo.GehegeHinzufügen(g3);
            zoo.GehegeHinzufügen(g4);
            zoo.GehegeHinzufügen(g5);
            zoo.GehegeHinzufügen(g6);
            zoo.GehegeHinzufügen(g7);
            zoo.GehegeEntfernen(g1);
            zoo.GehegeEntfernen(g3);
            zoo.GehegeEntfernen(g5);
            zoo.AusgabeZoo();


        }
    }
}