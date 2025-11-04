namespace Appdevhb25.KatjaHaemmerli.Aufgab66
{
    public class OOPIntro3
    {
        public static void Start()
        {            
            Personen personen = new Personen();
            personen.Name = "Katja";
            personen.Geburtstag = new DateTime(1991,12,30);
            personen.Grösse = 1.63;
            personen.Gewicht = 46;

            personen.PrintPersonenAttribute();
        }
    }
}