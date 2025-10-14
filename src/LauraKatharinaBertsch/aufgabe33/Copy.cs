namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe33
{
    public class Copy
    {
        public static void Start()
        {



            int[] originalArray = [1, 2, 3, 4, 5];




            int[] result = CopieArray(originalArray);


            originalArray[0] = -1;

            for (int i = 0; i < result.Length; i++)
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