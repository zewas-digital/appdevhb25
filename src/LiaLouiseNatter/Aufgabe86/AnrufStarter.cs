namespace Appdevhb25.LiaLouiseNatter.Aufgabe86
{
    public class AnrufStarter
    {
        public static void Start()
        {
            Anruf a1 = new Anruf("Lia",DateTime.Now, "123489");
            Anruf a2 = new Anruf("Pia",DateTime.Now , "122139");
            Anruf a3 = new Anruf("Mia",DateTime.Now, "176489");
            Anruf a4 = new Anruf("Kia",DateTime.Now, "121289");

            Callcenter callcenter = new Callcenter();
            callcenter.Anrufen(a1);
            callcenter.Anrufen(a2);
            callcenter.Anrufen(a3);
            callcenter.Anrufen(a4);
            System.Console.WriteLine("Anrufe werden in folgender Reihenfolge Abgearbeitet: ");
            callcenter.AnrufeAbarbeiten();
        }
    }
}