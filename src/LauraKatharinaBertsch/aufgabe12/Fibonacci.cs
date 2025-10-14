namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe12
{
    public class Fibonacci
    {
        public static void Start(int fibo)
        {

            int fibonacci1 = 1;
            int fibonacci2 = 0;
            int fibonacci3;

            Console.WriteLine("Die ersten " + fibo + " Folgenglieder lauten:");
            Console.WriteLine(fibonacci2);
            Console.WriteLine(fibonacci1);

            for (int i = 1; i < fibo; i++)
            {
                fibonacci3 = fibonacci1 + fibonacci2;
                fibonacci2 = fibonacci1;
                fibonacci1 = fibonacci3;
                Console.WriteLine(fibonacci3);
            }

        }
    }
}
