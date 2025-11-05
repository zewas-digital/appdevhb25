namespace Appdevhb25.KerimAlkis.Aufgabe42
{
    public class ProcessNumbers
    {
        public static void Start()
        {
            int[] numbers = [100, -6, 23, -87, 1, 0, 77, -543];
            int[] berechnungen = Berechne(numbers);
            foreach(var ergebnis in berechnungen)
            {
                System.Console.WriteLine(ergebnis);
            }
        }
        public static int[] Berechne(int[] numbers)
        {
            int[] berechnungen = new int[2];
            foreach(var zahl in numbers)
            {
                if (zahl < 0) { berechnungen[0] += 1; }
                else{ berechnungen[1] += zahl; }
            }
            return berechnungen;
        }
    }
}