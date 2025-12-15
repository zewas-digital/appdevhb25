public class Gruppe
{
    List<Person> personen = new List<Person>();
    public void PersonHinzufuegen(Person person) // ojektgebunden !nicht! statisch
    {
        personen.Add(person);
    }   
   
    public double KleinsterWertErmitterln(string feldname)
    {
        double kleinstes = 0;

        switch(feldname)
        {
            case "Gewicht":
                kleinstes = personen.Min(person => person.Gewicht);
                break;
            case "Alter":
                kleinstes = personen.Min(person => person.Alter);
                break;
            case "Grösse":
                kleinstes = personen.Min(person => person.Groesse);
                break;   
        } 
        
        return kleinstes;
    }
    public double GroessterWertErmitterln(string feldname)
    {
        double groesstes = 0;

        switch(feldname)
        {
            case "Gewicht":
                groesstes = personen.Max(personen => personen.Gewicht);
                break;
            case "Alter":
                groesstes = personen.Max(personen => personen.Alter);
                break;
            case "Grösse":
                groesstes = personen.Max(personen => personen.Groesse);
                break;   
        }
        return groesstes;
    }
    public double DurschnittswertErmitteln(string feldname)
    {
        double durchschnittsWert = 0;

        switch(feldname)
        {
            case "Gewicht":
                durchschnittsWert = personen.Average(person => person.Gewicht);
                break;
            case "Alter":
                durchschnittsWert = personen.Average(person => person.Alter);
                break;
            case "Grösse":
                durchschnittsWert = personen.Average(person => person.Groesse);
                break;  
        } 
        return durchschnittsWert;
    }
}