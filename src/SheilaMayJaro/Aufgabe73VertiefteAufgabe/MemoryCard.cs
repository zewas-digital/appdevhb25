namespace Appdevhb25.SheilaMayJaro.Aufgabe73
{
public class MemoryCard : Hardware
    {
        public int StorageSpace; 
        
        public MemoryCard(int memory, string model, string serialNumber):base(model, serialNumber)
        {
            StorageSpace = memory;
        }
        public MemoryCard(string model, string serialNumber):base(model, serialNumber)
        {
            
        }
        public MemoryCard(string serialNumber, string model, int memory) : base(serialNumber, model)
        {
            StorageSpace = memory;
        }
        
        public override string ToString()
        {
            return
            $"Modell: {Model,10}\nSeriennummer: {SerialNumber,5}\nSpeicherplatz: {StorageSpace} MB";
        }
    }
}