using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ColorRGB
    {
        private double r, g, b;
        private double c, m, y;
        public double R {
            get { return r; }
            set { r = value < 0 ? 0 : (value > 1 ? 1 : value); }
        }
        public double G
        {
            get { return g; }
            set { g = value < 0 ? 0 : (value > 1 ? 1 : value); }
        }
        public double B
        {
            get { return b; }
            set { b = value < 0 ? 0 : (value > 1 ? 1 : value); }
        }
        public double C
        {
            get { return c; }
            set { c = value < 0 ? 0 : (value > 1 ? 1 : value); }
        }
        public double M
        {
            get { return m; }
            set { m = value < 0 ? 0 : (value > 1 ? 1 : value); }
        }
        public double Y
        {
            get { return y; }
            set { y = value < 0 ? 0 : (value > 1 ? 1 : value); }
        }
        private ColorRGB(double r, double g, double b) {
            R = r;
            G = g;
            B = b;

        }
        public static ColorRGB Color_RGBM(double r, double g, double b) {
            return new ColorRGB(r, g, b);
        }
        public static ColorRGB Color_CMYM(double c, double m, double y)
        {
            var r = 1 - c;
            var g = 1 - m;
            var b = 1 - y;
            return new ColorRGB(r, g, b);
        }
        public static ColorRGB operator +(ColorRGB c, ColorRGB c1){
            var r = c.R + c1.R;
            var g = c.G + c1.G;
            var b = c.B + c1.B;
            return new ColorRGB(r, g, b);
        }
        public static ColorRGB operator -(ColorRGB c, ColorRGB c1)
        {
            var r = c.R - c1.R;
            var g = c.G - c1.G;
            var b = c.B - c1.B;
            return new ColorRGB(r, g, b);
        }
        public override string ToString()
        {
            return $"({R}, {G}, {B})";
        }
    }
}
