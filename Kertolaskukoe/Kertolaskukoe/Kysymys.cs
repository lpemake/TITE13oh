using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertolaskukoe
{
    class Kysymys
    {
        private static Random generaattori = new Random();
        private int oikeaVastaus;

        public Kysymys()
        {

        }

        public string KysyLaskutoimitus()
        {
            int luku1 = generaattori.Next(2, 11);
            int luku2 = generaattori.Next(2, 11);

            oikeaVastaus = luku1 * luku2;

            string kysymys = luku1 + " * " + luku2 + " = ?";
            return kysymys;
        }

        public bool TarkistaVastaus(int kayttajanVastaus)
        {
            return kayttajanVastaus == oikeaVastaus;
        }

    }
}
