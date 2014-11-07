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
        /// jäsenmuuttujat
        /// </summary>
        private string name;
        private double x;
        private double y;

        /// <summary>
        /// Konstruktori
        /// </summary>
        /// <param name="name">pisteen nmi</param>
        /// <param name="x">x-koordinaatti</param>
        /// <param name="y">y-koordinaatti</param>
        public XYPoint(string name, double x, double y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public double Distance(XYPoint anotherPoint)
        {
            double dx = this.x - anotherPoint.x;
            double dy = this.y - anotherPoint.y;

            double d = dx * dx + dy * dy;
            return Math.Sqrt(d);
        }

        public override string ToString()
        {
            return name + " " + x + " " + y;
        }

        public void SetX(double x)
        {
            this.x = x;
        }
        public double GetX()
        {
            return this.x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        public double GetY()
        {
            return this.y;
        }

    }
}
