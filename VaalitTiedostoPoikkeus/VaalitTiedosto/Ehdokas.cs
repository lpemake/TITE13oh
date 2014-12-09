using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaalitTiedosto
{
    class Ehdokas
    {
        public string Etunimi { get; private set; }
        public string Sukunimi { get; private set; }
        public string Puolue { get; private set; }
        public int Aanimaara { get; set; }

        public Ehdokas(string etunimi, string sukunimi, string puolue,
            int aanimaara)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Puolue = puolue;
            Aanimaara = aanimaara;
        }

        public override string ToString()
        {
            return Sukunimi + " " + Aanimaara;
        }
    }
}
