namespace Appdevhb25.KatjaHaemmerli.AufgabeZooTeil1
{
    public  class Gehege
    {
        public string GehegeName;
        public Gehege(string gehegeName)
        {
            GehegeName = gehegeName;
        }
        public void AusgabeNamen(string gehegeName)
        {
            System.Console.WriteLine(gehegeName);
        }
    }
}