using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma1
{
    class Employee
    {
        /// <summary>
        /// Member variables (jäsenmuuttujat)
        /// </summary>
        private string firstName;
        private string lastName;
        private int birthYear;
        private double salary;

        /// <summary>
        /// Konstruktori
        /// </summary>
        public Employee(string firstName,
            string lastName, int x)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            birthYear = x;
            // salary = 0;
        }

        /// <summary>
        /// "Setteri"
        /// </summary>
        /// <param name="salary">palkka</param>
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        /// <summary>
        /// "Getteri
        /// </summary>
        /// <returns>palkka</returns>
        public double GetSalary()
        {
            return this.salary;
        }

        public void RaiseSalary(double percent)
        {
            double x = this.salary * percent / 100.0;
            this.salary += x;
        }

        /// <summary>
        /// Outputs all the member variables in one string
        /// </summary>
        public override string ToString()
        {
            return firstName + " " +
                lastName + " " + birthYear +
                " " + salary;
        }

    }
}
