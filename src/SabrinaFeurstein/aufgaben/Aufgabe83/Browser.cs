namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe83
{
    public class Browser
    {
        public static void Start()
        {
            Stack<History> history = new Stack<History>();
            Stack<History> historyForward = new Stack<History>();

            Console.Write("Enter a website: ");
            history.Push(new History(Console.ReadLine()!));
            Console.WriteLine("\n---- Visiting " + history.Peek() + " ----");

            while (true)
            {
                string navigation;

                if (historyForward.Count == 0)
                {
                    if (history.Count == 1)
                        Console.WriteLine("\nEnter '<' to end the program or '+' to visit a new website: ");
                    else
                        Console.WriteLine("\nEnter '<' to go back or '+' to visit a new website: ");

                    navigation = Console.ReadLine()!;

                    if (navigation.Equals("+"))
                    {
                        Console.Write("Enter a website: ");
                        history.Push(new History(Console.ReadLine()!));
                        Console.WriteLine("---- Visiting " + history.Peek() + " ----");
                    }
                    else if (navigation.Equals("<"))
                    {
                        historyForward.Push(history.Pop());
                        if (history.Count == 0)
                        {
                            Console.WriteLine("\nHistory is empty! Ending Program...");
                            break;
                        }
                        else
                            Console.WriteLine("\n---- Visiting " + history.Peek() + " ----");
                    }
                    else if (navigation.Equals(">"))
                    {
                        Console.WriteLine("\nNo websites available to go forward to!");
                    }
                    else
                        Console.Write("Invalid Input! ");
                }

                else
                {
                    if (history.Count == 1)
                        Console.WriteLine("\nEnter '<' to end the program, '>' to go forward or 'new' to visit a new website: ");
                    else
                        Console.WriteLine("\nEnter '<' to go back, '>' to go forward or 'new' to visit a new website: ");

                    navigation = Console.ReadLine()!;

                    if (navigation.Equals("+"))
                    {
                        Console.Write("Enter a website: ");
                        history.Push(new History(Console.ReadLine()!));
                        Console.WriteLine("---- Visiting " + history.Peek() + " ----");
                        historyForward.Clear();
                    }
                    else if (navigation.Equals("<"))
                    {
                        historyForward.Push(history.Pop());
                        if (history.Count == 0)
                        {
                            Console.WriteLine("\nHistory is empty! Ending Program...");
                            break;
                        }
                        else
                            Console.WriteLine("\n---- Visiting " + history.Peek() + " ----");
                    }
                    else if (navigation.Equals(">"))
                    {
                        Console.WriteLine("\n---- Visiting " + historyForward.Peek() + " ----");
                        history.Push(historyForward.Pop());
                    }
                    else
                        Console.Write("Invalid Input! ");
                }
            }
        }
    }
}