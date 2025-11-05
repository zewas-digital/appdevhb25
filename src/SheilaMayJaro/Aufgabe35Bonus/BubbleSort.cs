using System; 

namespace Appdevhb25.SheilaMayJaro.Aufgabe35
{
    public class BubbleSort
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 35)");
            //Link zur Aufgabe https://de.wikipedia.org/wiki/Bubblesort 
            int[] numbers = new int[5];
            numbers = [4, 2, 5, 3, 1];
            foreach (int item in numbers)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            PrintBubbleSort(numbers);
            int[] bigNumbers = new int[9];
            bigNumbers = [5, 7, 2, 4, 3, 9, 1, 8, 6];
            Console.WriteLine();
            Console.WriteLine();  
            foreach (int item in bigNumbers)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            PrintBubbleSort(bigNumbers);
            int[] NumbersSorted = new int[] { 1, 2, 3, 4, 5 };
            PrintBubbleSort(NumbersSorted); 
            

        }
        public static void PrintBubbleSort(int[] array) //kein Rückgabewert 
        {
            int count = 0;
            int temp = 0;
            bool wasSwitched = false; //um die Anzahl an Schleifen zu verringern, soll es mit dem bool erkennen, dass die Zahlenfolge schon sortiert ist 
            for (int i = array.Length; i > 0; i--)
            {
                wasSwitched = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1]) // j wird mit dem rechten Nachbar verglichen, wenn j größer ist, wird er nach rechts verschoben 
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        //um die Zahlen zu tauschen, wird ein temporärer Speicherplatz mit temp gemacht, um j+1 dort zwischenzuspeichern
                        wasSwitched = true;
                    }
                    count++;
                }
                if (wasSwitched == false)
                {
                    break;
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Count: {count}");
            foreach (int item in array) //die foreach-Schleife dient dazu die einzelnen Elemente auszugeben 
            {
                Console.Write($"{item}\t"); 
            }
        }
    }
}