namespace Appdevhb25.SheilaMayJaro.Aufgabe84
{
    public class Aufgabe84
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 84)");
            List<ISubject> InventoryList = new List<ISubject>();
            InventoryList.Add(new MemoryCard());
            InventoryList.Add(new Camera()); 
            InventoryList.Add(new CameraLens()); 

            foreach (ISubject item in InventoryList)
            {
                System.Console.WriteLine(item.GetSubjectInfo());;
            }
        }
    }
}