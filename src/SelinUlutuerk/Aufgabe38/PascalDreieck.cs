using System;
using Appdevhb25.SelinUlutuerk.Arrays;
using static Appdevhb25.SelinUlutuerk.Arrays.ArrayHelper;

namespace Appdevhb25.SelinUlutuerk.Aufgabe38
{
    class PascalDreieck
    {
        public static void Start()
        {
            Console.WriteLine("Welche größe soll das Pascal Dreieck haben?");

            int groesse;

            while (!int.TryParse(Console.ReadLine(), out groesse) || groesse <= 0)
            {
                Console.WriteLine("Bitte geben Sie eine gültige positive ganze Zahl ein:");
            }

            int[,] pascal = new int[groesse, groesse];

            // Damit nicht jedes mal überprüft werden muss ob temp == 0 ist sonder es von anfang an auf 1 gesetzt ist.
            // for (int i = 0; i < groesse; i++)
            // {
            //     pascal[i, 0] = 1;
            //     pascal[0, i] = 1;
            // }
            
            for (int i = 0; i < groesse; i++)
            {
                pascal[i, 0] = 1;
                pascal[0, i] = 1;

                if (i > 0)
                {
                    for (int j = 1; j < groesse; j++)
                    {
                        int temp = pascal[i - 1, j];
                        if(temp == 0)
                        {
                            temp = 1;
                        }
                        pascal[i, j] = temp + pascal[i, j - 1];
                    }
                }
            }
            ArrayHelper.PrintArray(pascal);
        }
    }
}