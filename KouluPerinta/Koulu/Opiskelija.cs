using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koulu
{
    class Opiskelija : Henkilo
    {
        public int Opintopisteet { get; set; }

        public Opiskelija(string etunimi, string sukunimi,
            int syntVuosi, int opintopisteet)
            : base(etunimi, sukunimi, syntVuosi)
        {
            this.Opintopisteet = opintopisteet;
        }

        public override string ToString()
        {
            // yhteiset tiedot saadaan kantaluokan
            // ToString-metodista
            return base.ToString() + " " + Opintopisteet;
        }
    }
}
