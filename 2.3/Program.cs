using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Иван", "Ерёмов", 554.06);
            Console.WriteLine("Введите налоговый сбор в процентах");
            int.TryParse((Console.ReadLine()), out int result);
            int tax = result;
            employee.MonthlySalary(tax);
            Console.WriteLine($"{employee.Surname} {employee.Name} зарплата = {employee.Salary}");
            Console.ReadLine();
        }
    }
}
