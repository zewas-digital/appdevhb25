using System.Net.Http.Headers;
using Appdevhb25.NoahHois.Aufgabe69;

namespace Appdevhb25.NoahHois.Aufgabe69
{
    public class ProgramMotorrad
    {

        public static void Start()
        {
            Motorrad[] motorcycles = new Motorrad[4];
            string[] dye = new string[3];
            Motorrad firstMotorcycle = new Motorrad(540, MotorcycleColor.BLAU, 100, 18_000, "FK293");
            Motorrad secondMotorcycle = new Motorrad(0, MotorcycleColor.SCHWARZ, 200, 25_000, "D294");
            Motorrad thirdMotorcycle = new Motorrad(10_000, MotorcycleColor.ROT, 70, 5_000, "FK982");
            Motorrad StandartMotorrad = new Motorrad();
            motorcycles[0] = firstMotorcycle;
            motorcycles[1] = secondMotorcycle;
            motorcycles[2] = thirdMotorcycle;
            motorcycles[3] = StandartMotorrad;

            foreach (Motorrad m in motorcycles)
            {
                m.Print();
                for (int i = 0; i < dye.Length; i++)
                    m.Color = MotorcycleColor.SCHWARZ;
                Console.WriteLine();
            }
        }
    }
}