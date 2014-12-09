using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvaaminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Lapsiluokka lapsi = new Lapsiluokka(0, 0);
            KantaLuokka joku = lapsi;

            joku.Metodi1();
            joku.Metodi2();
            Console.WriteLine(joku.ToString());
        }
    }

    class KantaLuokka
    {
        private int a;
        protected int b;

        public KantaLuokka(int a, int b)
        {
            this.a = a; this.b = b;
        }

        public virtual void Metodi1()
        {
            Console.WriteLine("KantaLuokka.Metodi1");
            a += 10;
            b += 10;
        }
        public virtual void Metodi2()
        {
            Console.WriteLine("KantaLuokka.Metodi2");
            a += 100;
            b += 100;
        }

        public override string ToString()
        {
            return a + " " + b;
        }
    }

    class Lapsiluokka : KantaLuokka
    {
        public Lapsiluokka(int a, int b)
            : base(a, b)
        {
            // base.a += 1000; ei onnistu, koska 'a' on private
            base.b += 1000; // onnistuu, koska 'b' on protected
        }

        // pitäisi käyttää override-avainsanaa
        public void Metodi1()
        {
            Console.WriteLine("Lapsiluokka.Metodi1");
            b += 1;
        } 
        // metodi2 on tehty "oikein"
        public override void Metodi2()
        {
            Console.WriteLine("Lapsiluokka.Metodi2");
            b += 1;
        }

    }
}
