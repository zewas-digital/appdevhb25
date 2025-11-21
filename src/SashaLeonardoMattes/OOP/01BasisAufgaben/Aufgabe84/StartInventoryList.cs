using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe84
{
    public class InventoryListCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            List<IObject> myObjects = new List<IObject>();

            myObjects.Add(new Car("1Auto1"));
            myObjects.Add(new MotorCycle("2Motorcycle2"));
            myObjects.Add(new Camera("3Camera3"));


            foreach (var item in myObjects)
            {
                System.Console.WriteLine(item.GetObjectInfo());
            }
        }

        
        
    }
}
