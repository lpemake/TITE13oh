using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma1
{
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan Employee-olio
            Employee antti =
                new Employee("Antti", "Sukunimi",
                    1833);

            antti.SetSalary(1000);
            double antinPalkka =
                antti.GetSalary();

            // metodin kutsu
            string s = antti.ToString();
            Console.WriteLine(s);

            antti.RaiseSalary(10);
            Console.WriteLine(antti.ToString());

            // olioviittaus
            Employee a = antti;
            a.RaiseSalary(10);
            Console.WriteLine(antti.ToString());
        }
    }
}
