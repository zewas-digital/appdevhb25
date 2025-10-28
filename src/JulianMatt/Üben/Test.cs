using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        int[] count = new int[14];


        int outputpos = 0;
        int outputneg = 0;

        for (int i = 0; i < count.Length; i++)
        {
            count[i] = (i - 15);
        }
        foreach (int elem in count)
        {
            if (elem < 0)
            {
                outputneg += elem;
            }
            if (elem > 0)
            {
                outputpos += 1;
            }
        }
        int[] together = new int[] { outputpos, outputneg };



        return together;
    }
}