namespace Appdevhb25.MarcelSimma.week02
{
    public class Copy
    {
        public static void Start()
        {
            int original = 5;
            int copy = CopyVariable(original);
            original = 6;

            Console.WriteLine(@$"Wert der ursprünglichen Variable: {original}
Wert der kopierten Variable: {copy}");

            int[] originalArray = [1, 2, 3];

            int[] copiedArray = CopyArray(originalArray);

            int[] copiedArray2 = CopyArray2(originalArray);

            originalArray[0] = -1;

            for (int i = 0; i < originalArray.Length; i++)
            {
                System.Console.WriteLine(originalArray[i]);
                // Die Werte im Array werden über den Index i abgerufen.
            }

            System.Console.WriteLine();

            foreach (int elem in copiedArray)
            {
                System.Console.WriteLine(elem);
                // Der aktuelle Wert aus dem Array wird über die elem Variable bereitgestellt.
            }

            System.Console.WriteLine();

            foreach (int elem in copiedArray2)
            {
                System.Console.WriteLine(elem);
            }
        }

        // Array kopieren mit Call by Reference
        public static int[] CopyArray(int[] array)
        {
            int[] copy = array;
            return copy;
        }

        // Array kopieren mit Call by value
        public static int[] CopyArray2(int[] array)
        {
            int[] copy = new int[array.Length];

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = array[i];
            }
            return copy;
        }

        public static int CopyVariable(int a)
        {
            int b = a;
            return b;
        }
    }
}