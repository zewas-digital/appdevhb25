using System.Runtime.CompilerServices;
using Appdevhb25.LiaLouiseNatter.Aufgabe48;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe82
{
    public class Browserhistory
    {
        Stack<string> browserHistory = new Stack<string>();
        public void NewWebsite()
        {
            System.Console.WriteLine("Search for your Website: ");
            string wantedWebsite = Console.ReadLine();
            browserHistory.Push(wantedWebsite);
            printBrowserHistory();
        }

        public void LastWebsite()
        {
            browserHistory.Pop();
            printBrowserHistory();
        }

        public void printBrowserHistory()
        {
            System.Console.WriteLine("Your current history: ");
            System.Console.WriteLine("----------------------");
            foreach(string search in browserHistory)
            {
                System.Console.WriteLine(search);
            }
            System.Console.WriteLine("----------------------");
            string currentWebsite = browserHistory.Peek();
            System.Console.WriteLine($"You are currently on the website: {currentWebsite}");
            chooseButton();

        }

        public void chooseButton()
        {
            if(browserHistory.Count == 0 || browserHistory.Count == 1)
            {
                System.Console.WriteLine("You cannot go back, search for a new website [w] or end the Program.");
                string chosenActionEmptyHistory = Console.ReadLine();

                if(chosenActionEmptyHistory == "w" || chosenActionEmptyHistory == "W")
                {
                    NewWebsite();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                System.Console.WriteLine("Do you want to go back[r] or open a new Website[w]? [r/w] ");
                string chosenAction = Console.ReadLine();

                if(chosenAction == "r" || chosenAction == "R")
                {
                    LastWebsite();
                }
                if(chosenAction == "w" || chosenAction == "W")
                {
                    NewWebsite();
                }
                else
                {
                    System.Console.WriteLine("Your input was invald, try again!");
                    System.Console.WriteLine("----------------------");
                    chooseButton();
                }
            }
           
        }
    }
}