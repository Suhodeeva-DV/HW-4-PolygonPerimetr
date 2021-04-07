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

            Polygon figure = new Polygon(dot1, dot2, dot3, dot4);

            Console.WriteLine($"Периметр многоугоьника {figure.NamePolygon()} равен {figure.Perimetr()}");
        }
    }
}
