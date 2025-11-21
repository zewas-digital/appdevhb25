using Appdevhb25.KerimAlkis.Aufgabe04;

namespace Appdevhb25.KerimAlkis.Test
{
    public class Test
    {
        public static void Start()
        {
            Queue<string> test = new Queue<string>();
            test.Enqueue("1");
            test.Enqueue("2");
            test.Enqueue("3");
            test.Enqueue("4");
            test.Enqueue("5");


            for(int i = 0; i < test.Count+i; i++)
            {
                System.Console.WriteLine(test.Dequeue());
            }
        }
    }
}