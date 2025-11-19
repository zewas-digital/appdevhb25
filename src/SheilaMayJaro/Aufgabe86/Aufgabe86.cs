namespace Appdevhb25.SheilaMayJaro.Aufgabe86
{
    public class Aufgabe86
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 86)");
            Call voiceMail = new Call();
            voiceMail.AddCall(new Call("Winter","004345645487"));
            voiceMail.AddCall(new Call("Huber", "004321565455"));
            voiceMail.AddCall(new Call("Kornblume", "0049524515445"));
            voiceMail.ListeningToCalls();
        }
    }
}