using System;
namespace Appdevhb25.KatjaHaemmerli.AufgabeZoo
{
    public class Zoo
    {
        public string ZooName;
        public string Gruendungsjahr;
        public List<Gehege> ListeVonGehegen = new List<Gehege>();
        public Zoo(string zooName, string gruendungsjahr)
        {
            ZooName = zooName;
            Gruendungsjahr = gruendungsjahr;
        }
        public void GehegeHinzufuegen(Gehege gehege)
        {
            ListeVonGehegen.Add(gehege);            
        }
        public void GehegeEntfernen(Gehege gehegeName)
        {
            ListeVonGehegen.Remove(gehegeName);            
        }
        public void AusgabeNamen()
        {
            System.Console.WriteLine($"├── Zoo:{ZooName}, gegründet {Gruendungsjahr}");

            foreach (Gehege gehege in ListeVonGehegen)
            {
                System.Console.WriteLine($"|  ├── Gehege: {gehege.GehegeName}");
                foreach (Tier tier in gehege.tierListe)
                {
                    tier.AusgabeNamen();
                }             
            }
            
        }
    }
}