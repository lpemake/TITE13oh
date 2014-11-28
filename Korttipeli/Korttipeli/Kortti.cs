using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttipeli
{
    class Kortti
    {
        public string Maa { get; private set; }
        public int Arvo { get; private set; }

        public Kortti(string maa, int arvo)
        {
            Maa = maa;
            Arvo = arvo;
        }

        public override string ToString()
        {
            string s = Maa + " ";

            switch (Arvo)
            {
                case 11:
                    s += "jätkä";
                    break;
                case 12:
                    s += "rouva";
                    break;
                case 13:
                    s += "kunkku";
                    break;
                case 1:
                    s += "ässä";
                    break;
                default:
                    s += Arvo;
                    break;
            }
            return s;
        }
    }
}
