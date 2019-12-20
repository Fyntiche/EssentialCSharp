using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Login = "1";
            user.Name = "Ivan";
            user.Surname = "Eryomov";
            user.Age = 25;
            user.Show();

            User user1 = new User("1", "Иван", "Ерёмов", 25);
            user1.Show();
            Console.ReadKey();
        }
    }
}
