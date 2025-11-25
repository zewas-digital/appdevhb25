using System.Net;

namespace Appdevhb25.NoahHois.Aufgabe83
{
    public class ProgramBrowserhistoryExtended
    {
        public static void Start()
        {
            Stack<History> stack = new();
            stack.Push(new History("test", DateTime.Now));
            stack.Push(new History("test2", DateTime.Now));
            stack.Push(new History("test3", DateTime.Now));
            stack.Push(new History("test4", DateTime.Now));
            stack.Peek();
            System.Console.WriteLine(stack.Pop().ToString());
            System.Console.WriteLine(stack.Pop().ToString());
            System.Console.WriteLine(stack.Pop().ToString());
            System.Console.WriteLine(stack.Pop().ToString());
        }
    }
}