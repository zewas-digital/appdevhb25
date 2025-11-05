using System.Runtime.CompilerServices;

namespace Appdevhb25.NoahHois.ZusatzAufgabe1
{
    public class ZusatzAufgabe1
    {
        public static void Start()
        {
            string report;
            int infoCount = 0;
            int warningCount = 0;
            int errorCount = 0;
            using (StreamReader stream = new StreamReader(@"C:\Users\NOHO\Documents\VSCode Projekte\appdevhb25\src\NoahHois\Woche4\ZusatzAufgabe\input.txt"))
            {
                report = stream.ReadLine();
                string error = "ERROR";
                string warning = "WARNING";
                string info = "INFO";
                bool checkReport;
                while (report != null)
                {
                    if (checkReport = report.Contains(error))
                    {
                        errorCount++;
                    }
                    if (checkReport = report.Contains(warning))
                    {
                        warningCount++;
                    }
                    if (checkReport = report.Contains(info))
                    {
                        infoCount++;
                    }
                    report = stream.ReadLine();
                }
                Console.WriteLine("INFO: " + infoCount);
                Console.WriteLine("WARNING: " + warningCount);
                Console.WriteLine("ERROR: " + errorCount);
            }
        }
    }
}