using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ColorCMY
    {
        private double r, g, b;
        private double c, m, y;
        public double R
        {
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
        private ColorCMY(double c, double m, double y) {
            C = c;
            M = m;
            Y = y;
        }
        public static ColorCMY Color_CMYM(double c, double m, double y)
        {
            return new ColorCMY(c, m, y);
        }
        public static ColorCMY Color_RGBM(double r, double g, double b)
        {
            var c = 1 - r;
            var m = 1 - g;
            var y = 1 - b;
            return new ColorCMY(c, m, y);
        }
        public static ColorCMY operator +(ColorCMY c2, ColorCMY c1)
        {
            var c = c2.C + c1.C;
            var m = c2.M + c1.M;
            var y = c2.Y + c1.Y;
            return new ColorCMY(c,m,y);
        }
        public static ColorCMY operator -(ColorCMY c2, ColorCMY c1)
        {
            var c = c2.C - c1.C;
            var m = c2.M - c1.M;
            var y = c2.Y - c1.Y;
            return new ColorCMY(c,m,y);
        }
        public override string ToString()
        {
            return $"({C}, {M}, {Y})";
        }
    }

}
