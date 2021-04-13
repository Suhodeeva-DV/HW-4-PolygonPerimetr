using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_PolygonPerimetr
{
    public class Polygon
    {
        List<Point> ListDots;
        public string NamePolygon { get; }

        public Polygon(Point dot1, Point dot2, Point dot3)
        {
            ListDots = new List<Point> { dot1, dot2, dot3};
            NamePolygon = dot1.Name + dot2.Name + dot3.Name;
        }

        public Polygon(Point dot1, Point dot2, Point dot3, Point dot4)
        {
            ListDots = new List<Point> { dot1, dot2, dot3, dot4 };
            NamePolygon = dot1.Name + dot2.Name + dot3.Name + dot4.Name;
        }

        public Polygon(Point dot1, Point dot2, Point dot3, Point dot4, Point dot5)
        {
            ListDots = new List<Point> { dot1, dot2, dot3, dot4, dot5 };
            NamePolygon = dot1.Name + dot2.Name + dot3.Name + dot4.Name + dot5.Name;
        }


        public double Perimetr()
        {
            int lastI = ListDots.Count - 1;

            double perimeter = 0.0;
            for (int i = 0; i < ListDots.Count; ++i)
            {
                int nextI = i == lastI ? 0 : i + 1;
                perimeter += Distance(ListDots[i], ListDots[nextI]);
            }
            return perimeter;
        }

        public double Distance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }


    }
}
