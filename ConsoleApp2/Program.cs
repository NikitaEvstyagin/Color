using System.Drawing;

namespace ConsoleApp2 {
    public class Program
    {
        public static void Main() {
            ColorRGB colorRGB1 = ColorRGB.Color_RGBM(5,0,-2);
            ColorRGB colorRGB2 = ColorRGB.Color_CMYM(5, 0, -2);
            ColorCMY colorCMY1 = ColorCMY.Color_CMYM(1, 2, 3);
            ColorCMY colorCMY2 = ColorCMY.Color_CMYM(2, 3, -26);

            Console.WriteLine(colorRGB1);
            Console.WriteLine(colorRGB2);
            Console.WriteLine();
            Console.WriteLine(colorRGB1 + colorRGB2);
            Console.WriteLine(colorRGB1 - colorRGB2);
            Console.WriteLine();
            Console.WriteLine(colorCMY1);
            Console.WriteLine(colorCMY2);
            Console.WriteLine();
            Console.WriteLine(colorCMY1 + colorCMY2);
            Console.WriteLine(colorCMY1 - colorCMY2);
        
        }
    }
}