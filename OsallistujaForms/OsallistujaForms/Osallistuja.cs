using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsallistujaForms
{
    public class Osallistuja
    {
        public string Sukunimi { get; set; }
        public string Etunimi { get; set; }
        public string Puhelinnumero { get; set; }
        public bool Sukupuoli { get; set; }

        public Osallistuja(string s, string e,
            string p, bool sp)
        {
            Sukunimi = s;
            Etunimi = e;
            Puhelinnumero = p;
            Sukupuoli = sp;
        }

        public override string ToString()
        {
            return Sukunimi + " " + Etunimi;
        }
    }
}
