public class Person
{
    // die Gruppen unterscheiden sich durch ihre unterschiede (Beispiel Zelle tot und lebendig, beide haben die koordinaten x und y aber
    // aber die eine Zelle hat die variabel zum übergeben lebendig und und die andere tot)
    public string Name;    
    public int Alter;
    public double Groesse;
    public double Gewicht;

    //Konstruktor

    public Person(string name, int alter, double groesse, double gewicht)
    {
        Name = name;
        Alter = alter;
        Groesse = groesse;
        Gewicht = gewicht;
    }  
}
