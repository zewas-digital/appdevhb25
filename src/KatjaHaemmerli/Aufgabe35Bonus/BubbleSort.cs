using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.KatjaHaemmerli.Aufgabe20;


namespace Appdevhb25.KatjaHaemmerli.Aufgabe35Bonus
{
    public class BubbleSort
    {

        public static void Bubble()
        {            
            int[] array = new int[] { 3, 4, 1, 2 };
            int temp; // Variable um Werte zwischen zu speichern

            // Array durchgehen
            for (int i = 0; i < array.Length; i++)
            {
                // Zahlen durchgehen und sortieren
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1]) // wenn vorherige Zahl grösse ist als die nächste Zahl:
                    {
                        temp = array[j + 1]; // vorherige Zahl wird in temporäre Variable gespeichert                        
                        array[j + 1] = array[j]; // vorherige Zahl nimmt Platz von nächster ein                        
                        array[j] = temp; // Zwischengespeicherte Zahl nimmt platz von vorheriger Zahl ein                        
                    }
                }
            }
            
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            
        }
    }
}
                // ersten Zahlen miteinander vergleichen. Wenn erste Zahl grösser ist als die zweite dann tauschen die beiden ihre Plätze
                // dann wird die zweite zahl mit der dritten verglichen ist die dritte kleiner tauschen die beiden ihre Plätze usw. bis jede elemente verglichen und sortiert wurden.
                // variable zum wert zeischen speichern! sonst geht beim tauschen der eine wert verlohren