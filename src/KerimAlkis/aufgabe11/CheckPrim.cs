namespace Appdevhb25.KerimAlkis.Aufgabe11
{
    public class CheckPrim
    {
        public static void Start()
        {
            int zahl;
            do
            {
                Console.Clear();
                System.Console.WriteLine("Zahl: ");
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    zahl = inputNumber; break;
                }
            } while (true);


            int entscheidung = 0;
            for (int i = zahl - 1; i >= 1; i--)
            {
                if (i == 1)
                {
                    entscheidung = 1;
                }
                else if (zahl % i == 0)
                {
                    entscheidung = -1;
                    break;
                }
            }
            Console.WriteLine(entscheidung);
        }
    }
}