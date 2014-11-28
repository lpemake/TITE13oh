using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koulu
{
    class Henkilo
    {
        public string Etunimi { get; private set; }
        public string Sukunimi { get; private set; }
        public int Syntymavuosi { get; private set; }        

        public Henkilo(string etunimi, string sukunimi,
            int syntymavuosi)
        {
            this.Etunimi = etunimi;
            this.Sukunimi = sukunimi;
            this.Syntymavuosi = syntymavuosi;
        }

        public int LaskeIka(int nykyinenVuosi)
        {
            return nykyinenVuosi - Syntymavuosi;
        }

        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + Syntymavuosi;
        }
    }
}
