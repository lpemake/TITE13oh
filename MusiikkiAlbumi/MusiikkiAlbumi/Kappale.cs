using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusiikkiAlbumi
{
    class Kappale
    {
        private string nimi;
        private string tekija;
        private TimeSpan kesto;

        public Kappale(string nimi,
            string tekija, TimeSpan kesto)
        {
            this.nimi = nimi;
            this.tekija = tekija;
            this.kesto = kesto;
        }

        public override string ToString()
        {
            int minuutit = kesto.Minutes;
            int sek = kesto.Seconds;
            return nimi + " " + minuutit + "\"" + sek;
        }

    }
}
