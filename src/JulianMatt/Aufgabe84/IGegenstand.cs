using System.Security.Cryptography.X509Certificates;

public interface IGegenstand
{ 
    public string InventoryNumber {get;}

    public string GetGegenstandInfo();

}