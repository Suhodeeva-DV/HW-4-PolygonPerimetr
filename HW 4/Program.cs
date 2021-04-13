using System;

namespace HW_4_PolygonPerimetr
{
    class Program
    {
        static void Main(string[] args)
        {
            Point dot1 = new Point("A", 0, 10);
            Point dot2 = new Point("B", 6, 10);
            Point dot3 = new Point("C", 6, 0);
            Point dot4 = new Point("D", 0, 0);
            Point dot5 = new Point("E", 7, 8);

            Polygon figure1 = new Polygon (dot1, dot2, dot3);
            Polygon figure2 = new Polygon(dot1, dot2, dot3, dot4);
            Polygon figure3 = new Polygon(dot1, dot2, dot3, dot4, dot5);

            Console.WriteLine($"P({figure1.NamePolygon}) = {figure1.Perimetr()}");
            Console.WriteLine($"P({figure2.NamePolygon}) = {figure2.Perimetr()}");
            Console.WriteLine($"P({figure3.NamePolygon}) = {figure3.Perimetr()}");

        }
    }
}
