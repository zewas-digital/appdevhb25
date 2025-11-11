using System;
using System.Runtime.InteropServices;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe68
{
    public class CameraCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            Camera c1 = new Camera();
            c1.Model = "AAA";
            c1.Manufacturer = "A";
            c1.FocalLength = 30;
            c1.MegaPixel = 30;

            Camera c2 = new Camera();
            c2.Model = "BBB";
            c2.Manufacturer = "B";
            c2.FocalLength = -5;
            c2.MegaPixel = 30000000;

            Camera c3 = new Camera();
            c3.Model = "CCC";
            c3.Manufacturer = "C";
            c3.FocalLength = 20;
            c3.MegaPixel = 374236;

            c1.TakePhoto();
            c2.TakePhoto();
            c3.TakePhoto();

        }
    }
}
