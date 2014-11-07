using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koordinaatit1
{
    class Pallokoordinaatit
    {
        public double R { get; set; } // etäisyys
        public double Alfa { get; set; }
        public double Beta { get; set; }

        public Pallokoordinaatit(double r, double alfa, double beta)
        {
            R = r;
            Alfa = alfa;
            Beta = beta;
        }
    }
}
