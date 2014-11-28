using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpiskelijaTesti
{
    class Opiskelija
    {
        private string etunimi;
        private string sukunimi;
        private string koodi;
        private int opintopisteet;
        private int syntymaVuosi;
        private DateTime syntAika;

        private static int laskuri = 1;

        public Opiskelija(string etunimi, string sukunimi,
            int syntymaVuosi)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.koodi = laskuri.ToString();
            this.syntymaVuosi = syntymaVuosi;
            this.syntAika =
                new DateTime(syntymaVuosi, 1, 1);
            laskuri++;
        }

        public static int GetLaskuri()
        {
            return laskuri;
        }

        public int LaskeIka(DateTime nyt)
        {
            // kahden ajanhetken erotuksessa
            // voi käyttää TimeSpania
            TimeSpan ero = nyt - syntAika;
            int paivat = ero.Days;
            return paivat / 365;
        }

        public string GetKoodi()
        {
            return koodi;
        }

        public int GetOpintopisteet()
        {
            return opintopisteet;
        }

        public void SetOpintopisteet(int opintopisteet)
        {
            this.opintopisteet = opintopisteet;
        }

        public string GetNimi()
        {
            return etunimi + " " + sukunimi;
        }

        public override string ToString()
        {
            return etunimi + " " + sukunimi + " " +
                opintopisteet + " " + koodi;
        }

        public int LaskeIka(int nykyinenVuosi)
        {
            return nykyinenVuosi - this.syntymaVuosi;
        }
    }
}
