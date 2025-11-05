using System;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe35
{
    class BubbleSort
    {
        public static void Start()
        {
            int[] sort = [22, 7, 3, 10, 20];

            for (int i = 0; i < sort.Length - 1; i++)
            {
                for (int j = 0; j < sort.Length - i - 1; j++)
                {
                    if (sort[j] > sort[j + 1])
                    {
                        int temp = sort[j];
                        
                        sort[j] = sort[j + 1];
                        sort[j + 1] = temp;
                    }
                }
            }
            
            Console.Write("Sortierter array: ");
            for (int i = 0; i < sort.Length; i++)
            {
                Console.Write(sort[i] + " ");
            }
            Console.WriteLine();
        }
    }
}