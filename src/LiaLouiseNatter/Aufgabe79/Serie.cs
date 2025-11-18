namespace Appdevhb25.LiaLouiseNatter.Aufgabe79
{
    public class Series
    {
        public string _name { get; set; }
        public int serienId { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public void Schauspieler(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }
      
    
    }
}