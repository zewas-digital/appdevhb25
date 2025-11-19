using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe82
{
    public class BrowserhistoryCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            Stack<string> browserhistory = new Stack<string>();
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
                            System.Console.WriteLine("\nDu bist jetzte auf der Website \"" + browserhistory.Peek() + "\"\n");
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
                    browserhistory.Push(input);
                    System.Console.WriteLine("\nDu bist jetzte auf der Website \"" + input + "\"\n");
                }
            } while (true);
        }

        
        
    }
}
