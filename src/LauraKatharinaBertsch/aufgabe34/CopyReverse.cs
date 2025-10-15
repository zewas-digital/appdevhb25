namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe34
{
    public class CopyReverse
    {
        public static void Start()
        {
            
            int[] originalArray = { 1, 2, 3, 4, 5 };
            int[] result = CopieArray(originalArray);

            for (int i = result.Length - 1; i >= 0; i--)
            {
                System.Console.WriteLine(result[i]);
            }
        }

        public static int[] CopieArray(int[] oArray)
        {
            int[] newArray = new int[oArray.Length];

            for (int i = 0; i < oArray.Length; i++)
            {
                newArray[i] = oArray[i];
            }
            return newArray;
        }
    }
}