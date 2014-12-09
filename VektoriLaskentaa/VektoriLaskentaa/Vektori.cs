using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektoriLaskentaa
{
    class Vektori
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vektori(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }  
        public double Pituus()
        {   // vektorin pituuden laskenta
            double d = X * X + Y * Y + Z * Z;
            return Math.Sqrt(d);
        }
        public void Lisaa(Vektori toinenVektori)
        {
            this.X += toinenVektori.X;
            this.Y += toinenVektori.Y;
            this.Z += toinenVektori.Z;
        }
        public static Vektori Summa(Vektori a, Vektori b)
        {
            Vektori c = new Vektori(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
            return c;
        }
        public override string ToString()
        {
            string s = string.Format("{0}i + {1}j + {2}k", X, Y, Z);
            return s;
        }

        public void Vahenna(Vektori toinenVektori)
        {
            this.X -= toinenVektori.X;
            this.Y -= toinenVektori.Y;
            this.Z -= toinenVektori.Z;
        }

        public static Vektori Erotus(Vektori a, Vektori b)
        {
            Vektori c = new Vektori(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
            return c;
        }
        
    }
}
