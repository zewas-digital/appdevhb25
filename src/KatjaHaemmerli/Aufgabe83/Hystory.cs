namespace Appdevhb25.KatjaHaemmerli.Aufgabe83
{
    public class Hystory
    {
        string UserInput;
        DateTime Besuchszeit;
        public Hystory(string userInput)
        {
            UserInput = userInput;
            // Zeit speichern wenn user eine Webseite besucht/eingibt
            Besuchszeit = DateTime.Now;
            System.Console.WriteLine(Besuchszeit);
        }

        public override string ToString()
        {
            return "Besuchte Website " + UserInput + " Besuchszeit " + Besuchszeit;
        }
    }
}