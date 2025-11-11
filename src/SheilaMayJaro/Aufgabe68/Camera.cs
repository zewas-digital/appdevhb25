namespace Appdevhb25.SheilaMayJaro.Aufgabe68
{
    public class Aufgabe68
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 68)");
            Camera.TakeFoto();
            Camera camera = new Camera();
            camera.FocalLengthMax = 180;
            camera.FocalLengthMin = 20;
            camera.Manufacturer = "Precision Optical Instruments, Co., Ltd.";
            camera.Model = "Canon EOS R50";
            camera.Megapixel = 24.1;

            camera.OutputCameraProperties();

            camera.FocalLengthMax = 220;
            camera.FocalLengthMin = 5;

            System.Console.WriteLine(camera.FocalLengthMax);
            System.Console.WriteLine(camera.FocalLengthMin);

            camera.FocalLengthMax = 150;
            camera.FocalLengthMin = 25;

            camera.OutputCameraProperties();


        }
    }
}