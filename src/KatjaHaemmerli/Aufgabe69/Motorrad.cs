
namespace Appdevhb25.KatjaHaemmerli.Aufgabe69
{
    public class Motorrad 
    {
        public string Model {get; set;}
        public string Farbe {get; set;}
        public string Kennzeichen {get; set;}       

        public Motorrad(string marke, string farbe, string kennzeichen)
        {
            Model = marke; 
            Farbe = farbe;
            Kennzeichen = kennzeichen;            
            AusgabeMotoradEigenschaften();
        }

        public void AusgabeMotoradEigenschaften()
        {
            System.Console.WriteLine($"Model: {Model}");
            System.Console.WriteLine($"Farbe: {Farbe}");
        }
    }
}
