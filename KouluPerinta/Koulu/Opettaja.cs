using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koulu
{
    class Opettaja : Henkilo
    {
        public double Palkka { get; set; }

        public Opettaja(string etunimi, string sukunimi, double palkka,
            int syntymaVuosi)
            : base(etunimi, sukunimi, syntymaVuosi)
        {
            this.Palkka = palkka;
        }


        public override string ToString()
        {
            return base.ToString() + " " + Palkka;
        }

    }
}
