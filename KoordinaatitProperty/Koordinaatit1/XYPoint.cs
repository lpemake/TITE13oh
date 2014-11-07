using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koordinaatit1
{
    class XYPoint
    {
        /// <summary>
        /// ominaisuudet (properties)
        /// </summary>
        public string Name { get; private set; }
        public double X { get; set; }
        public double Y { get; set; }

        /// <summary>
        /// Konstruktori
        /// </summary>
        /// <param name="name">pisteen nmi</param>
        /// <param name="x">x-koordinaatti</param>
        /// <param name="y">y-koordinaatti</param>
        public XYPoint(string name, double x, double y)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
        }

        public double Distance(XYPoint anotherPoint)
        {
            double dx = this.X - anotherPoint.X;
            double dy = this.Y - anotherPoint.Y;

            double d = dx * dx + dy * dy;
            return Math.Sqrt(d);
        }

        public override string ToString()
        {
            return Name + " " + X + " " + Y;
        }
    }
}
