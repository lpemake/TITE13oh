using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vektorit3D
{
    struct Vektori
    {
        public double x;
        public double y;
        public double z;

        // alustaja
        public Vektori(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    struct PalloKoordinaatit
    {
        public double pituus;
        public double alfa;
        public double beta;

        // alustaja
        public PalloKoordinaatit(double p, double a, double b)
        {
            pituus = p;
            alfa = a * Math.PI / 180.0; // radiaaneiksi
            beta = b * Math.PI / 180.0; // radiaaneiksi
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vektori a;
            a.x = 1;
            a.y = 2;
            a.z = 3;

            Vektori b;
            b.x = 4;
            b.y = 5;
            b.z = 6;

            Console.WriteLine("b:n pituus on {0:F1}", Pituus(b));

            Vektori c = Erotus(a, b);
            Vektori yks = YksikkoVektori(c);

            Vektori esim = YksikkoVektori(Erotus(a, b));

            TulostaVektori(c);
            TulostaVektori(yks);

            Vektori ab = new Vektori(1, -6, 2);
            Vektori ac = new Vektori(-2, -7, 8);
            Vektori r = Ristitulo(ab, ac);
            Vektori normaali = YksikkoVektori(r);
            TulostaVektori(normaali);
            Console.WriteLine(Pituus(normaali));

            Console.WriteLine("kulma = {0:F1}", VektorienKulma(ab, ac));


            // Lentokoneiden välinen etäisyys
            PalloKoordinaatit A1 =
                new PalloKoordinaatit(10, -35, 60);
            PalloKoordinaatit A2 =
                new PalloKoordinaatit(15, 45, 50);

            // muunnetaan suorakulmaisiksi koordinaateiksi
            Vektori A1xyz = PalloToXYZ(A1);
            TulostaVektori(A1xyz);
            Vektori A2xyz = PalloToXYZ(A2);
            TulostaVektori(A2xyz);

            // erotus
            Vektori a12 = Erotus(A1xyz, A2xyz);

            // erotusvektorin pituus on etäisyys
            double pituus = Pituus(a12);

            TulostaVektori(a12);
            Console.WriteLine("Pituus: {0:F2}", pituus);

        }

        static Vektori PalloToXYZ(PalloKoordinaatit p)
        {
            Vektori c;
            c.x = p.pituus * Math.Sin(p.beta) * Math.Cos(p.alfa);
            c.y = p.pituus * Math.Sin(p.beta) * Math.Sin(p.alfa);
            c.z = p.pituus * Math.Cos(p.beta);

            return c;
        }

        static double VektorienKulma(Vektori a, Vektori b)
        {
            double pistetulo = Pistetulo(a, b);
            double aPituus = Pituus(a);
            double bPituus = Pituus(b);

            double alfa = Math.Acos(pistetulo / ( aPituus * bPituus));
            // asteiksi
            alfa = alfa * 180.0 / Math.PI;
            return alfa;
        }

        static double Pistetulo(Vektori a, Vektori b)
        {
            double p = a.x * b.x + a.y * b.y + a.z * b.z;
            return p;
        }

        static Vektori Ristitulo(Vektori a, Vektori b)
        {
            Vektori c;
            c.x = a.y * b.z - a.z * b.y;
            c.y = a.z * b.x - a.x * b.z;
            c.z = a.x * b.y - a.y * b.x;

            return c;
        }

        static void TulostaVektori(Vektori a)
        {
            Console.WriteLine("[{0:F1}, {1:F1}, {2:F1}]", a.x, a.y, a.z);
        }

        static Vektori YksikkoVektori(Vektori a)
        {
            Vektori c;
            double pituus = Pituus(a);
            c.x = a.x / pituus;
            c.y = a.y / pituus;
            c.z = a.z / pituus;
            return c;
        }

        static Vektori Erotus(Vektori a, Vektori b)
        {
            Vektori c;
            c.x = b.x - a.x;
            c.y = b.y - a.y;
            c.z = b.z - a.z;
            return c;
        }

        // kahden pisteen välinen etäisyys
        static double Etaisyys(Vektori a, Vektori b)
        {
            Vektori c = Erotus(a, b);
            double p = Pituus(c);
            return p;
        }

        static double Pituus(Vektori a)
        {
            double d = Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
            return d;
        }
    }
}
