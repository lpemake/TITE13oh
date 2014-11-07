using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koordinaatit1
{
    class Program
    {
        static void Main(string[] args)
        {
            XYPoint pisteA =
                new XYPoint("A", 1, 2);
            XYPoint pisteB =
                new XYPoint("B", 4, 5);
            pisteA.SetX(4);
            pisteB.SetY(9);

            // lasketaan pisteiden välinen
            // etäisyys
            double d = Distance(pisteA, pisteB);
            Console.WriteLine(d);

            pisteA.Distance(pisteB);
            Console.WriteLine(d);
        }

        static double Distance(XYPoint a,
            XYPoint b)
        {
            double dx = a.GetX() - b.GetX();
            double dy = a.GetY() - b.GetY();

            double d = dx * dx + dy * dy;
            return Math.Sqrt(d);
        }
    }
}
