using System;
using System.Runtime.Intrinsics.Arm;

namespace Appdevhb25.LiaLouiseNatter.BonusaufgabeDoppelmayr
{
    public class ChristmasOrnaments
    {
        public static void Start(int size)
        {
            //Triangle(size);
            //Trunk(size);
            UserInput(size);
            
        }

        public static bool UserInput(int size)
        {
            while (true)
            {
                try
                {
                    System.Console.Write("Do you want Tree 1 or Tree 2 [1 2]:");
                    int Treechoice = Convert.ToInt32(Console.ReadLine());

                    System.Console.Write("How tall should the Tree be?:");
                    size = Convert.ToInt32(Console.ReadLine());
                    
                    
                }
                catch
                {
                    System.Console.WriteLine("Only numbers 1 and 2 are allowed");
                }
            }   
        }
        

























        public static void Triangle(int size)
        {
            for (int i = 1; i <= size - 1; i++)
            {
                for (int j = i; j < size; j++)
                {

                    System.Console.Write(" ");
                }

                for (int j = 1; j <= i - 1; j++)
                {
                    if (i == 1 || j == 1)
                    {
                        System.Console.Write("xx");
                    }



                    else
                    {
                        System.Console.Write("o");
                        System.Console.Write("x");
                    }

                }

                System.Console.WriteLine();

            }

        }

        public static void Trunk(int size)
        {
            int trunkHeigt = size / 3;
            int trunkWidth = size / 4;
            for (int i = 0; i < trunkHeigt -1; i++)
            {
                
                for (int j = 1; j < size - trunkHeigt / 2 - 1; j++)
                {
                    System.Console.Write(" ");
                }
                
                
                for (int k = 0; k < trunkWidth +3; k++)
                {
                    System.Console.Write("+");
                }
                System.Console.WriteLine();
                
            }
           
        }

      
    }
}