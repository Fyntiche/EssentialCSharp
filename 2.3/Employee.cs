using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Employee
    {
        private string name;
        public string Name { get => name; set => name = value; }

        private string surname;
        public string Surname { get => Name; set => Name = value; }

        private double salary;
        public double Salary { get => salary; set => salary = value; }

        private string position;
        public string Position { get => position; set => position = value; }

        private DateTime dateAt;
        public DateTime DateAt { get => dateAt; set => dateAt = value; }

        public Employee(string name, string surname, double salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            DateAt = DateTime.Now;
        }

        public void MonthlySalary(double tax)
        {
            DateTime dateNow = new DateTime();
            double salary = tax / 100 + Salary * ((dateNow.Year - DateAt.Year)/100 + 100);
            Salary = salary;
        }
    }
}
