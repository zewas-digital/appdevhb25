namespace Appdevhb25.SheilaMayJaro.Aufgabe84
{
    public interface ISubject
    {
        //da mit der Inventurnummer nichts berechnet wird, benutzt man einen String
        public string? InventoryNumber{get; set;}
        public string GetSubjectInfo();
    }
}