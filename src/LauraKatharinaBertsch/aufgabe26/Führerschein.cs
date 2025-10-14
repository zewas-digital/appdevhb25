using System.Reflection.Metadata.Ecma335;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe26
{
    public class Führerschein
    {
        public static void Start()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Wir prüfen ob du einen Führerschein machen darfst");
                Console.WriteLine("Schreibe ein Alter und einen Namen");
                int age = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                bool canDriveMoped = DrivingLicenseMoped(age);
                bool canDriveAuto = DrivingLicenseAuto(age);
                string output = "";

                if (canDriveAuto)
                {
                    output = "Auto: Ja,";
                }
                else
                {
                    output = "Auto: Nein,";
                }
                if (canDriveMoped)
                {
                    output = output + " Moped: Ja,";
                }
                else
                {
                    output = output + " Moped: Nein,";
                }
                if (canDriveAuto && canDriveMoped)
                {
                    output = output + " beides: Ja";
                }
                else
                {
                    output = output + " beides: Nein";
                }
                Console.WriteLine(name + " " + age + " = " + output);

                i++;
            }
        }

        public static bool DrivingLicenseMoped(int age)
        {
            if (age >= 15)
            {
                return true;
            }
            return false;
        }
        public static bool DrivingLicenseAuto(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            return false;
        }
    }
}