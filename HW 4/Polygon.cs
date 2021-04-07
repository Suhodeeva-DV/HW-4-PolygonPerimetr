using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_PolygonPerimetr
{
    public class Polygon
    {
        Point dot1;
        Point dot2;
        Point dot3;
        Point dot4;

        public Polygon(Point dot1, Point dot2, Point dot3, Point dot4)
        {
            this.dot1 = dot1;
            this.dot2 = dot2;
            this.dot3 = dot3;
            this.dot4 = dot4;
        }

        public string NamePolygon()
        {
            string name = dot1.Name + dot2.Name + dot3.Name + dot4.Name;
            return name;
        }

        public double Perimetr()
        {
            double d1 = Math.Sqrt(Math.Pow((dot2.X - dot1.X), 2) + Math.Pow((dot2.Y - dot1.Y), 2));
            double d2 = Math.Sqrt(Math.Pow((dot3.X - dot2.X), 2) + Math.Pow((dot3.Y - dot2.Y), 2));
            double d3 = Math.Sqrt(Math.Pow((dot4.X - dot3.X), 2) + Math.Pow((dot4.Y - dot3.Y), 2));
            double d4 = Math.Sqrt(Math.Pow((dot1.X - dot4.X), 2) + Math.Pow((dot1.Y - dot4.Y), 2));
            return (d1 + d2 + d3 + d4);
        }


    }
}
