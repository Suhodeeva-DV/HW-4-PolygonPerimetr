using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_PolygonPerimetr
{
    public class Point
    {
        public string Name { get; }
        public int X { get; }   
        public int Y { get; }   

        public Point(string nameDot, int x, int y)
        {
            Name = nameDot;                           
            X = x;
            Y = y;
        }
        
    }
}
