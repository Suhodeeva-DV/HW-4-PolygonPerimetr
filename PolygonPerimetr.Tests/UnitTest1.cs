using System;
using Xunit;

namespace HW_4_PolygonPerimetr.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PolygonDistanceTest()
        {
            Point point1 = new Point("A", 0, 0);
            Point point2 = new Point("B", 0, 5);
            Point point3 = new Point("C", 5, 0);
            Polygon polygon = new Polygon(point1, point2, point3);

            double result = polygon.Distance(point1, point2);

            Assert.Equal(5.0, result, 5);
        }

        [Fact]
        public void PolygonPerimetrTest()
        {
            Point point1 = new Point("A", 0, 0);
            Point point2 = new Point("B", 0, 5);
            Point point3 = new Point("C", 5, 0);
            Polygon polygon = new Polygon(point1, point2, point3);

            double result = polygon.Perimetr();

            Assert.Equal(17.071, result, 3);
        }
    }
}
