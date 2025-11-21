using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe83
{
    public class BrowserhistoryCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            Stack<Browserhistory> browserhistory = new Stack<Browserhistory>();
            string input;
            do
            {
                System.Console.WriteLine("Gib die Website ein, die du besuchen willst oder \"back\" um zurück zur letzten zu gehen.");
                input = Helper.checkUserInputString();
                if (input == "back")
                {
                    if (browserhistory.Count > 0)
                    {
                        browserhistory.Pop();
                        if (browserhistory.Count > 0)
                        {
                            System.Console.WriteLine(browserhistory.Peek().ToString());
                        }
                        else
                        {
                            System.Console.WriteLine("Keine Website mehr im Stack. Programm beendet.");
                        break;
                        }
                    }
                }
                else
                {
                    browserhistory.Push(new Browserhistory(input, DateTime.Now));
                    System.Console.WriteLine(browserhistory.Peek().ToString());
                }
            } while (true);
        }

        
        
    }
}
