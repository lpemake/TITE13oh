using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Paallikko : Tyontekija
    {
        public string Titteli { get; set; }

        public Paallikko(string etunimi,
            string sukunimi,
            int syntymavuosi,
            double palkka, string titteli)
            : base(etunimi, sukunimi,
            syntymavuosi, palkka)
        {
            this.Titteli = titteli;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Titteli;
        }

        public override void PalkanKorotus(double prosentti)
        {
            // päällikkö saa palkankorotuksen kaksinkertaisena
            base.PalkanKorotus(2 * prosentti);
        }
    }
}
