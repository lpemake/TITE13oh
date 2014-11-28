using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koulu
{
    class Opiskelija
    {
        public string Etunimi { get; private set; }
        public string Sukunimi { get; private set; }
        public int Opintopisteet { get; set; }

        public int Syntymavuosi
        {
            get;
            set;
        }

        public Opiskelija(string etunimi, string sukunimi,
            int opintopisteet)
        {
            this.Etunimi = etunimi;
            this.Sukunimi = sukunimi;
            this.Opintopisteet = opintopisteet;
        }

        public override string ToString()
        {
            return Sukunimi;
        }
    }
}
