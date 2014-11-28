using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPisteet
{
    class Point
    {
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Point(string n, double x,
            double y)
        {
            Name = n;
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return Name + " " + X + " " + Y;
        }
    }
}
